using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;

namespace CNegocio
{
    public class ServiciosTurnos
    {
        private static readonly TurnoRepository _turnoRepo = new TurnoRepository();
        public static (int turnoId, int numeroTurno, string mensaje) CrearTunos(int pacienteId, int medicoId, 
            int recepcionistaId, int prioridadSeleccionada, string observaciones)
        {
           return _turnoRepo.CrearTurno(
                    pacienteId, medicoId, recepcionistaId, 
                    prioridadSeleccionada, observaciones);
        }

        public static List<Turno> ColaDeTurnos(int? medicoId, int? especialidadId)
        {
            return _turnoRepo.ObtenerColaTurnos(medicoId, especialidadId);
        }

        public static List<Turno> HistorialPaciente(int pacienteid)
        {
            return _turnoRepo.HistorialPaciente(pacienteid);
        }
    }
}
