using CAccesoDatos.RepositoryPattern;
using CEntidades.Models;

namespace CNegocio
{
    /// <summary>
    /// Servicio de lógica de negocio para la gestión de turnos médicos.
    /// Provee métodos para crear, consultar y modificar turnos.
    /// </summary>
    public class ServiciosTurnos
    {
        private static readonly TurnoRepository _turnoRepo = new TurnoRepository();

        /// <summary>
        /// Crea un nuevo turno en el sistema.
        /// </summary>
        /// <param name="pacienteId">Identificador del paciente.</param>
        /// <param name="medicoId">Identificador del médico.</param>
        /// <param name="recepcionistaId">Identificador del recepcionista.</param>
        /// <param name="prioridadSeleccionada">Identificador de la prioridad.</param>
        /// <param name="observaciones">Observaciones adicionales.</param>
        /// <returns>Tupla con el ID del turno, número de turno y mensaje.</returns>
        public static (int turnoId, int numeroTurno, string mensaje) CrearTunos(int pacienteId, int medicoId, 
            int recepcionistaId, int prioridadSeleccionada, string observaciones)
        {
           return _turnoRepo.CrearTurno(
                    pacienteId, medicoId, recepcionistaId, 
                    prioridadSeleccionada, observaciones);
        }

        /// <summary>
        /// Obtiene la cola de turnos pendientes, opcionalmente filtrados por médico o especialidad.
        /// </summary>
        /// <param name="medicoId">Filtrar por médico (opcional).</param>
        /// <param name="especialidadId">Filtrar por especialidad (opcional).</param>
        /// <returns>Lista de turnos en cola.</returns>
        public static List<Turno> ColaDeTurnos(int? medicoId, int? especialidadId)
        {
            return _turnoRepo.ObtenerColaTurnos(medicoId, especialidadId);
        }

        /// <summary>
        /// Obtiene el historial de turnos de un paciente específico.
        /// </summary>
        /// <param name="pacienteid">Identificador del paciente.</param>
        /// <returns>Lista de turnos del paciente.</returns>
        public static List<Turno> HistorialPaciente(int pacienteid)
        {
            return _turnoRepo.HistorialPaciente(pacienteid);
        }

        /// <summary>
        /// Cambia la prioridad de un turno existente.
        /// </summary>
        /// <param name="turnoId">Identificador del turno.</param>
        /// <param name="nuevaPrioridad">Nueva prioridad.</param>
        /// <returns>True si se cambió correctamente.</returns>
        public bool CambiarPrioridadTurno(int turnoId, int nuevaPrioridad)
        {
            return _turnoRepo.CambiarPrioridadTurno(turnoId, nuevaPrioridad);
        }
    }
}
