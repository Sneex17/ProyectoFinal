using HospitalTurnos.Models;
using HospitalTurnos.ViewModels;

namespace HospitalTurnos.Services
{
    /// <summary>
    /// Implementación en memoria — reemplazar por EF Core cuando la BD esté lista.
    /// Toda la lógica de negocio (ordenamiento por prioridad, cambios de estado) vive aquí.
    /// </summary>
    public class InMemoryTurnoService : ITurnoService
    {
        // Catálogos seed 
        private readonly List<Prioridad> _prioridades = new()
        {
            new() { PrioridadId = 1, Nombre = "Normal",      Descripcion = "Paciente sin urgencia inmediata" },
            new() { PrioridadId = 2, Nombre = "Prioritario", Descripcion = "Paciente adulto mayor, embarazada o discapacitado" },
            new() { PrioridadId = 3, Nombre = "Emergencia",  Descripcion = "Riesgo de vida, atención inmediata" }
        };

        private readonly List<EstadoTurno> _estados = new()
        {
            new() { EstadoTurnoId = 1, Nombre = "Creado",     Descripcion = "En sala de espera" },
            new() { EstadoTurnoId = 2, Nombre = "EnAtencion", Descripcion = "Siendo atendido" },
            new() { EstadoTurnoId = 3, Nombre = "Atendido",   Descripcion = "Consulta finalizada" },
            new() { EstadoTurnoId = 4, Nombre = "Cancelado",  Descripcion = "Turno cancelado" }
        };

        private readonly List<Paciente> _pacientes = new()
        {
            new() { PacienteId = 1, Cedula = "001-1234567-8", Nombre = "María",   Apellido = "González", FechaNacimiento = new DateTime(1985, 3, 12), Sexo = "F", Direccion = "Av. Duarte #45", Seguro = "ARS Senasa", Correo = "maria.g@mail.com" },
            new() { PacienteId = 2, Cedula = "002-9876543-1", Nombre = "Carlos",  Apellido = "Martínez", FechaNacimiento = new DateTime(1972, 7, 25), Sexo = "M", Direccion = "C/ 27 de Febrero #12", Seguro = "ARS Humano" },
            new() { PacienteId = 3, Cedula = "003-5551234-9", Nombre = "Lucía",   Apellido = "Pérez",    FechaNacimiento = new DateTime(1995, 11, 3), Sexo = "F", Direccion = "Res. Los Jardines" },
            new() { PacienteId = 4, Cedula = "004-3334567-2", Nombre = "Roberto", Apellido = "Sánchez",  FechaNacimiento = new DateTime(1960, 1, 18), Sexo = "M", Direccion = "C/ Mella #89", Seguro = "ARS Universal" },
            new() { PacienteId = 5, Cedula = "005-7772345-0", Nombre = "Ana",     Apellido = "Ramírez",  FechaNacimiento = new DateTime(2001, 6, 30), Sexo = "F", Direccion = "Urb. La Esperanza" }
        };

        private readonly List<Medico> _medicos = new()
        {
            new() { MedicoId = 1, NLicencia = "MED-001", Nombre = "Jorge",   Apellido = "Herrera",  EspecialidadId = 1 },
            new() { MedicoId = 2, NLicencia = "MED-002", Nombre = "Carmen",  Apellido = "Vásquez",  EspecialidadId = 2 },
            new() { MedicoId = 3, NLicencia = "MED-003", Nombre = "Ricardo", Apellido = "Figueroa", EspecialidadId = 1 }
        };

        private readonly List<Asistente> _asistentes = new()
        {
            new() { AsistenteId = 1, Nombre = "Laura",  Apellido = "Torres",  AreaId = 1 },
            new() { AsistenteId = 2, Nombre = "Miguel", Apellido = "Castillo", AreaId = 2 }
        };

        // Turnos en memoria
        private readonly List<Turno> _turnos;
        private int _nextTurnoId = 1;
        private int _nextNumeroTurno = 1;

        public InMemoryTurnoService()
        {
            _turnos = SeedTurnos();
        }

        // Lógica de negocio

        public ColaViewModel ObtenerCola(string? filtroEstado = null, string? filtroPrioridad = null)
        {
            var todos = _turnos.Select(MapToViewModel).ToList();

            // Aplicar filtros opcionales
            if (!string.IsNullOrWhiteSpace(filtroEstado))
                todos = todos.Where(t => t.EstadoNombre.Equals(filtroEstado, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!string.IsNullOrWhiteSpace(filtroPrioridad))
                todos = todos.Where(t => t.PrioridadNombre.Equals(filtroPrioridad, StringComparison.OrdinalIgnoreCase)).ToList();

            // Turno en atención
            var enAtencion = _turnos
                .FirstOrDefault(t => t.EstadoTurnoId == 2); // EnAtencion

            // Cola de espera: ordenar por prioridad DESC, luego fecha ASC
            var colaEspera = _turnos
                .Where(t => t.EstadoTurnoId == 1) // Creado
                .OrderByDescending(t => t.PrioridadId)
                .ThenBy(t => t.FechaHoraCreacion)
                .Select(MapToViewModel)
                .ToList();

            // Historial del día
            var historial = _turnos
                .Where(t => t.EstadoTurnoId == 3 || t.EstadoTurnoId == 4) // Atendido | Cancelado
                .OrderByDescending(t => t.FechaHoraFin ?? t.FechaHoraCreacion)
                .Select(MapToViewModel)
                .ToList();

            return new ColaViewModel
            {
                TurnoEnAtencion = enAtencion != null ? MapToViewModel(enAtencion) : null,
                ColaEspera = colaEspera,
                Historial = historial,
                TotalCreados = _turnos.Count(t => t.EstadoTurnoId == 1),
                TotalEmergencias = _turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 3),
                TotalPrioritarios = _turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 2),
                TotalNormales = _turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 1),
                TotalAtendidos = _turnos.Count(t => t.EstadoTurnoId == 3),
                FiltroEstado = filtroEstado,
                FiltroPrioridad = filtroPrioridad
            };
        }

        public List<TurnoViewModel> ObtenerTodos() =>
            _turnos.Select(MapToViewModel).ToList();

        public TurnoViewModel? ObtenerPorId(int turnoId)
        {
            var turno = _turnos.FirstOrDefault(t => t.TurnoId == turnoId);
            return turno is null ? null : MapToViewModel(turno);
        }

        public Turno CrearTurno(int pacienteId, int medicoId, int? asistenteId, int prioridadId, string? observaciones)
        {
            var turno = new Turno
            {
                TurnoId = _nextTurnoId++,
                NumeroTurno = _nextNumeroTurno++,
                PacienteId = pacienteId,
                MedicoId = medicoId,
                AsistenteId = asistenteId,
                PrioridadId = prioridadId,
                EstadoTurnoId = 1, // Creado
                Observaciones = observaciones,
                FechaHoraCreacion = DateTime.Now,
                // Relaciones de navegación
                Paciente = _pacientes.First(p => p.PacienteId == pacienteId),
                Medico = _medicos.First(m => m.MedicoId == medicoId),
                Asistente = asistenteId.HasValue ? _asistentes.FirstOrDefault(a => a.AsistenteId == asistenteId) : null,
                Prioridad = _prioridades.First(p => p.PrioridadId == prioridadId),
                EstadoTurno = _estados.First(e => e.EstadoTurnoId == 1)
            };

            _turnos.Add(turno);
            return turno;
        }

        public bool CambiarEstado(int turnoId, int nuevoEstadoId)
        {
            var turno = _turnos.FirstOrDefault(t => t.TurnoId == turnoId);
            if (turno is null) return false;

            var nuevoEstado = _estados.FirstOrDefault(e => e.EstadoTurnoId == nuevoEstadoId);
            if (nuevoEstado is null) return false;

            turno.EstadoTurnoId = nuevoEstadoId;
            turno.EstadoTurno = nuevoEstado;

            // Registrar tiempos según transición de estado
            if (nuevoEstadoId == 2) turno.FechaHoraInicio = DateTime.Now;  // EnAtencion
            if (nuevoEstadoId == 3 || nuevoEstadoId == 4) turno.FechaHoraFin = DateTime.Now; // Atendido | Cancelado

            return true;
        }

        public bool EliminarTurno(int turnoId)
        {
            var turno = _turnos.FirstOrDefault(t => t.TurnoId == turnoId);
            if (turno is null) return false;
            _turnos.Remove(turno);
            return true;
        }

        // Catálogos
        public List<Paciente> ObtenerPacientes() => _pacientes;
        public List<Medico> ObtenerMedicos() => _medicos;
        public List<Asistente> ObtenerAsistentes() => _asistentes;
        public List<Prioridad> ObtenerPrioridades() => _prioridades;
        public List<EstadoTurno> ObtenerEstados() => _estados;

        // Mapeador
        private static TurnoViewModel MapToViewModel(Turno t) => new()
        {
            TurnoId = t.TurnoId,
            NumeroTurno = t.NumeroTurno,
            PacienteNombre = t.Paciente.NombreCompleto,
            PacienteCedula = t.Paciente.Cedula,
            MedicoNombre = t.Medico.NombreCompleto,
            PrioridadNombre = t.Prioridad.Nombre,
            PrioridadCss = t.Prioridad.CssClass,
            EstadoNombre = t.EstadoTurno.Nombre,
            EstadoCss = t.EstadoTurno.CssClass,
            FechaHoraCreacion = t.FechaHoraCreacion,
            FechaHoraInicio = t.FechaHoraInicio,
            FechaHoraFin = t.FechaHoraFin,
            Observaciones = t.Observaciones
        };

        // Seed de datos de prueba
        private List<Turno> SeedTurnos()
        {
            var ahora = DateTime.Now;
            var lista = new List<Turno>
            {
                new() {
                    TurnoId = _nextTurnoId++, NumeroTurno = _nextNumeroTurno++,
                    PacienteId = 3, MedicoId = 1, AsistenteId = 1, PrioridadId = 3, EstadoTurnoId = 2,
                    FechaHoraCreacion = ahora.AddMinutes(-30), FechaHoraInicio = ahora.AddMinutes(-5),
                    Observaciones = "Dolor torácico agudo",
                    Paciente = _pacientes[2], Medico = _medicos[0], Asistente = _asistentes[0],
                    Prioridad = _prioridades[2], EstadoTurno = _estados[1]
                },
                new() {
                    TurnoId = _nextTurnoId++, NumeroTurno = _nextNumeroTurno++,
                    PacienteId = 4, MedicoId = 2, PrioridadId = 3, EstadoTurnoId = 1,
                    FechaHoraCreacion = ahora.AddMinutes(-20),
                    Observaciones = "Fractura de muñeca",
                    Paciente = _pacientes[3], Medico = _medicos[1],
                    Prioridad = _prioridades[2], EstadoTurno = _estados[0]
                },
                new() {
                    TurnoId = _nextTurnoId++, NumeroTurno = _nextNumeroTurno++,
                    PacienteId = 2, MedicoId = 1, AsistenteId = 2, PrioridadId = 2, EstadoTurnoId = 1,
                    FechaHoraCreacion = ahora.AddMinutes(-45),
                    Observaciones = "Adulto mayor, control presión",
                    Paciente = _pacientes[1], Medico = _medicos[0], Asistente = _asistentes[1],
                    Prioridad = _prioridades[1], EstadoTurno = _estados[0]
                },
                new() {
                    TurnoId = _nextTurnoId++, NumeroTurno = _nextNumeroTurno++,
                    PacienteId = 5, MedicoId = 3, PrioridadId = 1, EstadoTurnoId = 1,
                    FechaHoraCreacion = ahora.AddMinutes(-15),
                    Paciente = _pacientes[4], Medico = _medicos[2],
                    Prioridad = _prioridades[0], EstadoTurno = _estados[0]
                },
                new() {
                    TurnoId = _nextTurnoId++, NumeroTurno = _nextNumeroTurno++,
                    PacienteId = 1, MedicoId = 2, PrioridadId = 1, EstadoTurnoId = 3,
                    FechaHoraCreacion = ahora.AddHours(-2), FechaHoraInicio = ahora.AddHours(-1).AddMinutes(-30),
                    FechaHoraFin = ahora.AddHours(-1),
                    Paciente = _pacientes[0], Medico = _medicos[1],
                    Prioridad = _prioridades[0], EstadoTurno = _estados[2]
                }
            };

            return lista;
        }
    }
}