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
        Turno CrearTurno(int pacienteId, int medicoId, int? asistenteId, int prioridadId, string? observaciones);
        bool CambiarEstado(int turnoId, int nuevoEstadoId);
        bool EliminarTurno(int turnoId);

        // Catálogos (para llenar dropdowns en formularios futuros)
        List<Paciente> ObtenerPacientes();
        List<Medico> ObtenerMedicos();
        List<Asistente> ObtenerAsistentes();
        List<Prioridad> ObtenerPrioridades();
        List<EstadoTurno> ObtenerEstados();
    }
}