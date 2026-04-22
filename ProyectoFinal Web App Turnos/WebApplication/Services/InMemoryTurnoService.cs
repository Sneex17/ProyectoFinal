using HospitalTurnos.Models;
using HospitalTurnos.ViewModels;

namespace HospitalTurnos.Services
{
    /// <summary>
    /// Implementación en memoria.
    /// </summary>
    public class InMemoryTurnoService : ITurnoService
    {
        private readonly List<Prioridad> _prioridades = new()
        {
            new() { PrioridadId = 1, Nombre = "Alta", Descripcion = "Prioridad elevada" },
            new() { PrioridadId = 2, Nombre = "Media", Descripcion = "Prioridad estándar" },
            new() { PrioridadId = 3, Nombre = "Baja", Descripcion = "No urgente" },
            new() { PrioridadId = 4, Nombre = "Urgente", Descripcion = "Emergencia real" }
        };

        private readonly List<EstadoTurno> _estados = new()
        {
            new() { EstadoTurnoId = 1, Nombre = "Creado" },
            new() { EstadoTurnoId = 2, Nombre = "En Atencion" },
            new() { EstadoTurnoId = 3, Nombre = "Atendido" },
            new() { EstadoTurnoId = 4, Nombre = "Cancelado" }
        };

        private readonly List<Especialidad> _especialidades = new()
        {
            new() { EspecialidadId = 1, Nombre = "Medicina General" },
            new() { EspecialidadId = 2, Nombre = "Pediatría" },
            new() { EspecialidadId = 3, Nombre = "Cardiología" }
        };

        private readonly List<Paciente> _pacientes = new()
        {
            new() { PacienteId = 1, Cedula = "001-1234567-1", Nombre = "Juan",    Apellido = "Pérez",    FechaNacimiento = new DateTime(1985, 5, 20), Sexo = "M", Direccion = "Av. Principal 123" },
            new() { PacienteId = 2, Cedula = "002-7654321-2", Nombre = "María",   Apellido = "García",   FechaNacimiento = new DateTime(1992, 10, 12), Sexo = "F", Direccion = "Calle 45, Edif. B" },
            new() { PacienteId = 3, Cedula = "003-1122334-4", Nombre = "Carlos",  Apellido = "Sosa",     FechaNacimiento = new DateTime(1978, 3, 5), Sexo = "M", Direccion = "Res. Los Olivos" },
            new() { PacienteId = 4, Cedula = "004-9988776-6", Nombre = "Pedro",   Apellido = "Martínez", FechaNacimiento = new DateTime(2010, 12, 1), Sexo = "M", Direccion = "Pueblo Viejo" },
            new() { PacienteId = 5, Cedula = "005-7772345-0", Nombre = "Ana",     Apellido = "Ramírez",  FechaNacimiento = new DateTime(2001, 6, 30), Sexo = "F", Direccion = "Urb. La Esperanza" }
        };

        private readonly List<Medico> _medicos = new()
        {
            new() { MedicoId = 1, NLicencia = "MED-001", Nombre = "Jorge",   Apellido = "Herrera",  EspecialidadId = 1 },
            new() { MedicoId = 2, NLicencia = "MED-002", Nombre = "Carmen",  Apellido = "Vásquez",  EspecialidadId = 2 },
            new() { MedicoId = 3, NLicencia = "MED-003", Nombre = "Ricardo", Apellido = "Figueroa", EspecialidadId = 1 }
        };

        private readonly List<Recepcionista> _Recepcionistas = new()
        {
            new() { RecepcionistaId = 1, Nombre = "Laura",  Apellido = "Torres" },
            new() { RecepcionistaId = 2, Nombre = "Miguel", Apellido = "Castillo" }
        };

        private static List<Turno> _turnos = new();
        private static int _nextTurnoId = 1;
        private static int _nextNumeroTurno = 1;

        public InMemoryTurnoService()
        {
            if (!_turnos.Any())
                _turnos = SeedInitialTurnos();
        }

        public ColaViewModel ObtenerCola(string? filtroEstado = null, string? filtroPrioridad = null)
        {
            var enAtencion = _turnos.FirstOrDefault(t => t.EstadoTurnoId == 2);

            var queryEspera = _turnos.Where(t => t.EstadoTurnoId == 1);

            if (!string.IsNullOrWhiteSpace(filtroPrioridad))
                queryEspera = queryEspera.Where(t => t.Prioridad.Nombre == filtroPrioridad);

            var colaEspera = queryEspera
                .OrderBy(t => t.PrioridadId == 4 ? 0 : t.PrioridadId == 1 ? 1 : t.PrioridadId == 2 ? 2 : 3)
                .ThenBy(t => t.FechaHoraCreacion)
                .Select(t => MapToViewModel(t))
                .ToList();

            var queryHistorial = _turnos.Where(t => t.EstadoTurnoId == 3 || t.EstadoTurnoId == 4);

            if (!string.IsNullOrWhiteSpace(filtroEstado))
                queryHistorial = queryHistorial.Where(t => t.EstadoTurno.Nombre == filtroEstado);

            var historial = queryHistorial
                .OrderByDescending(t => t.FechaHoraFin ?? t.FechaHoraCreacion)
                .Select(t => MapToViewModel(t))
                .ToList();

            return new ColaViewModel
            {
                TurnoEnAtencion = enAtencion != null ? MapToViewModel(enAtencion) : null,
                ColaEspera = colaEspera,
                Historial = historial,
                TotalCreados = _turnos.Count(t => t.EstadoTurnoId == 1),
                TotalUrgentes = _turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 4),
                TotalAltas = _turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 1),
                TotalMedias = _turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 2),
                TotalBajas = _turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 3),
                TotalAtendidos = _turnos.Count(t => t.EstadoTurnoId == 3),
                FiltroEstado = filtroEstado,
                FiltroPrioridad = filtroPrioridad
            };
        }

        public List<TurnoViewModel> ObtenerTodos() =>
            _turnos.OrderByDescending(t => t.FechaHoraCreacion).Select(MapToViewModel).ToList();

        public TurnoViewModel? ObtenerPorId(int turnoId)
        {
            var t = _turnos.FirstOrDefault(x => x.TurnoId == turnoId);
            return t != null ? MapToViewModel(t) : null;
        }

        public Turno CrearTurno(int pacienteId, int medicoId, int? recepcionistaId, int prioridadId, string? observaciones)
        {
            var t = new Turno
            {
                TurnoId = _nextTurnoId++,
                NumeroTurno = _nextNumeroTurno++,
                PacienteId = pacienteId,
                MedicoId = medicoId,
                RecepcionistaId = recepcionistaId,
                PrioridadId = prioridadId,
                EstadoTurnoId = 1,
                Observaciones = observaciones,
                FechaHoraCreacion = DateTime.Now,
                Paciente = _pacientes.First(p => p.PacienteId == pacienteId),
                Medico = _medicos.First(m => m.MedicoId == medicoId),
                Prioridad = _prioridades.First(p => p.PrioridadId == prioridadId),
                EstadoTurno = _estados.First(e => e.EstadoTurnoId == 1),
                Recepcionista = recepcionistaId.HasValue ? _Recepcionistas.FirstOrDefault(r => r.RecepcionistaId == recepcionistaId) : null
            };
            _turnos.Add(t);
            return t;
        }

        public bool CambiarEstado(int turnoId, int nuevoEstadoId)
        {
            var t = _turnos.FirstOrDefault(x => x.TurnoId == turnoId);
            if (t == null) return false;
            t.EstadoTurnoId = nuevoEstadoId;
            t.EstadoTurno = _estados.First(e => e.EstadoTurnoId == nuevoEstadoId);
            if (nuevoEstadoId == 2) t.FechaHoraInicio = DateTime.Now;
            if (nuevoEstadoId == 3 || nuevoEstadoId == 4) t.FechaHoraFin = DateTime.Now;
            return true;
        }

        public bool EliminarTurno(int turnoId) => _turnos.RemoveAll(x => x.TurnoId == turnoId) > 0;

        public List<Paciente> ObtenerPacientes() => _pacientes;

        public Paciente? ObtenerPacientePorCedula(string cedula) =>
            _pacientes.FirstOrDefault(p => p.Cedula == cedula);

        public List<Especialidad> ObtenerEspecialidades() => _especialidades;

        public List<Medico> ObtenerMedicosPorEspecialidad(int especialidadId) =>
            _medicos.Where(m => m.EspecialidadId == especialidadId).ToList();

        public List<Medico> ObtenerMedicos() => _medicos;
        public List<Recepcionista> ObtenerRecepcionistas() => _Recepcionistas;
        public List<Prioridad> ObtenerPrioridades() => _prioridades;
        public List<EstadoTurno> ObtenerEstados() => _estados;

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

        private List<Turno> SeedInitialTurnos()
        {
            var ahora = DateTime.Now;
            return new List<Turno>
            {
                new() { TurnoId = _nextTurnoId++, NumeroTurno = _nextNumeroTurno++, PacienteId = 1, MedicoId = 1, PrioridadId = 4, EstadoTurnoId = 1, FechaHoraCreacion = ahora.AddMinutes(-5), Paciente = _pacientes[0], Medico = _medicos[0], Prioridad = _prioridades[3], EstadoTurno = _estados[0] },
                new() { TurnoId = _nextTurnoId++, NumeroTurno = _nextNumeroTurno++, PacienteId = 2, MedicoId = 2, PrioridadId = 1, EstadoTurnoId = 1, FechaHoraCreacion = ahora.AddMinutes(-10), Paciente = _pacientes[1], Medico = _medicos[1], Prioridad = _prioridades[0], EstadoTurno = _estados[0] }
            };
        }
    }
}
