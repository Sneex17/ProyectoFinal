using HospitalTurnos.Models;
using HospitalTurnos.ViewModels;

namespace HospitalTurnos.Services
{
    public interface ITurnoService
    {
        // Cola principal
        ColaViewModel ObtenerCola(string? filtroEstado = null, string? filtroPrioridad = null);

        // CRUD de turno
        List<TurnoViewModel> ObtenerTodos();
        TurnoViewModel? ObtenerPorId(int turnoId);

        // RecepcionistaId es requerido en BD (NOT NULL)
        Turno CrearTurno(int pacienteId, int medicoId, int recepcionistaId,
                         int prioridadId, string? observaciones);
        bool CambiarEstado(int turnoId, int nuevoEstadoId);
        bool EliminarTurno(int turnoId);

        // Catálogos para dropdowns
        List<Paciente> ObtenerPacientes();
        List<Medico> ObtenerMedicos();
        List<Recepcionista> ObtenerRecepcionistas();   // ← era ObtenerAsistentes
        List<Prioridad> ObtenerPrioridades();
        List<EstadoTurno> ObtenerEstados();
    }
}