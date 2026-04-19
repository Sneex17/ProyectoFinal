using HospitalTurnos.Data;
using HospitalTurnos.Models;
using HospitalTurnos.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace HospitalTurnos.Services
{
    /// <summary>
    /// Implementación real con EF Core + SQL Server.
    /// </summary>
    public class DbTurnoService : ITurnoService
    {
        private readonly HospitalTurnosContext _db;

        public DbTurnoService(HospitalTurnosContext db)
        {
            _db = db;
        }

        // ─── Cola principal ────────────────────────────────────────────────

        public ColaViewModel ObtenerCola(string? filtroEstado = null, string? filtroPrioridad = null)
        {
            // Turno en atención (EstadoTurnoId = 2)
            var enAtencion = _db.Turnos
                .Include(t => t.Paciente)
                .Include(t => t.Medico)
                .Include(t => t.Recepcionista)
                .Include(t => t.Prioridad)
                .Include(t => t.EstadoTurno)
                .FirstOrDefault(t => t.EstadoTurnoId == 2);

            // Cola de espera: solo Creados (1)
            var queryEspera = _db.Turnos
                .Include(t => t.Paciente)
                .Include(t => t.Medico)
                .Include(t => t.Recepcionista)
                .Include(t => t.Prioridad)
                .Include(t => t.EstadoTurno)
                .Where(t => t.EstadoTurnoId == 1);

            // Filtro por nombre de prioridad (opcional)
            if (!string.IsNullOrWhiteSpace(filtroPrioridad))
                queryEspera = queryEspera.Where(t => t.Prioridad.Nombre == filtroPrioridad);

            // Ordenamiento jerárquico: Urgente(4) > Alta(1) > Media(2) > Baja(3)
            var colaEspera = queryEspera
                .OrderBy(t => t.PrioridadId == 4 ? 0 : t.PrioridadId == 1 ? 1 : t.PrioridadId == 2 ? 2 : 3)
                .ThenBy(t => t.FechaHoraCreacion)
                .Select(t => MapToViewModel(t))
                .ToList();

            // Historial del día
            var queryHistorial = _db.Turnos
                .Include(t => t.Paciente)
                .Include(t => t.Medico)
                .Include(t => t.Prioridad)
                .Include(t => t.EstadoTurno)
                .Where(t => t.EstadoTurnoId == 3 || t.EstadoTurnoId == 4);

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
                TotalCreados = _db.Turnos.Count(t => t.EstadoTurnoId == 1),
                TotalUrgentes = _db.Turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 4),
                TotalAltas = _db.Turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 1),
                TotalMedias = _db.Turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 2),
                TotalBajas = _db.Turnos.Count(t => t.EstadoTurnoId == 1 && t.PrioridadId == 3),
                TotalAtendidos = _db.Turnos.Count(t => t.EstadoTurnoId == 3),
                FiltroEstado = filtroEstado,
                FiltroPrioridad = filtroPrioridad
            };
        }

        public List<TurnoViewModel> ObtenerTodos()
        {
            return _db.Turnos
                .Include(t => t.Paciente)
                .Include(t => t.Medico)
                .Include(t => t.Prioridad)
                .Include(t => t.EstadoTurno)
                .OrderByDescending(t => t.FechaHoraCreacion)
                .Select(t => MapToViewModel(t))
                .ToList();
        }

        public TurnoViewModel? ObtenerPorId(int turnoId)
        {
            var turno = _db.Turnos
                .Include(t => t.Paciente)
                .Include(t => t.Medico)
                .Include(t => t.Recepcionista)
                .Include(t => t.Prioridad)
                .Include(t => t.EstadoTurno)
                .FirstOrDefault(t => t.TurnoId == turnoId);

            return turno is null ? null : MapToViewModel(turno);
        }

        public Turno CrearTurno(int pacienteId, int medicoId, int recepcionistaId,
                                int prioridadId, string? observaciones)
        {
            var hoy = DateTime.Today;
            var ultimoNumero = _db.Turnos
                .Where(t => t.FechaHoraCreacion >= hoy)
                .OrderByDescending(t => t.NumeroTurno)
                .Select(t => (int?)t.NumeroTurno)
                .FirstOrDefault() ?? 0;

            var turno = new Turno
            {
                PacienteId = pacienteId,
                MedicoId = medicoId,
                RecepcionistaId = recepcionistaId,
                PrioridadId = prioridadId,
                EstadoTurnoId = 1,
                Observaciones = observaciones,
                NumeroTurno = ultimoNumero + 1,
                FechaHoraCreacion = DateTime.Now
            };

            _db.Turnos.Add(turno);
            _db.SaveChanges();

            _db.Entry(turno).Reference(t => t.Paciente).Load();
            _db.Entry(turno).Reference(t => t.Medico).Load();
            _db.Entry(turno).Reference(t => t.Recepcionista).Load();
            _db.Entry(turno).Reference(t => t.Prioridad).Load();
            _db.Entry(turno).Reference(t => t.EstadoTurno).Load();

            return turno;
        }

        public bool CambiarEstado(int turnoId, int nuevoEstadoId)
        {
            var turno = _db.Turnos.Find(turnoId);
            if (turno is null) return false;

            var estadoExiste = _db.EstadoTurnos.Any(e => e.EstadoTurnoId == nuevoEstadoId);
            if (!estadoExiste) return false;

            turno.EstadoTurnoId = nuevoEstadoId;

            if (nuevoEstadoId == 2)
                turno.FechaHoraInicio = DateTime.Now;
            if (nuevoEstadoId == 3 || nuevoEstadoId == 4)
                turno.FechaHoraFin = DateTime.Now;

            _db.SaveChanges();
            return true;
        }

        public bool EliminarTurno(int turnoId)
        {
            var turno = _db.Turnos.Find(turnoId);
            if (turno is null) return false;

            _db.Turnos.Remove(turno);
            _db.SaveChanges();
            return true;
        }

        public List<Paciente> ObtenerPacientes() =>
            _db.Pacientes.OrderBy(p => p.Apellido).ThenBy(p => p.Nombre).ToList();

        public List<Medico> ObtenerMedicos() =>
            _db.Medicos.OrderBy(m => m.Apellido).ToList();

        public List<Recepcionista> ObtenerRecepcionistas() =>
            _db.Recepcionistas.OrderBy(r => r.Apellido).ToList();

        public List<Prioridad> ObtenerPrioridades() =>
            _db.Prioridades.OrderBy(p => p.PrioridadId).ToList();

        public List<EstadoTurno> ObtenerEstados() =>
            _db.EstadoTurnos.OrderBy(e => e.EstadoTurnoId).ToList();

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
    }
}
