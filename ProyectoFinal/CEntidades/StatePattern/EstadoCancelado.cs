using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado final "Cancelado" dentro del patrón de estados para un turno.
    /// En este estado, el turno fue anulado y no admite ninguna transición adicional.
    /// </summary>
    public class EstadoCancelado: IEstadoTurno
    {
        /// <summary>
        /// Obtiene el identificador numérico del estado. Corresponde al valor 4 (Cancelado).
        /// </summary>
        public int EstadoTurnoId => 4;
        /// <summary>
        /// Obtiene el nombre descriptivo del estado actual.
        /// </summary>
        public string Nombre => "Cancelado";
        /// <summary>
        /// Intento de transición al estado "Creado". No tiene efecto porque el turno fue cancelado.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Creado(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Intento de transición al estado "En Atención". No tiene efecto porque el turno fue cancelado.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void EnAtencion(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Intento de transición al estado "Atendido". No tiene efecto porque el turno fue cancelado.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Atendido(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Intento de transición al estado "Cancelado". No tiene efecto porque el turno ya se encuentra en este estado.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Cancelado(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Intento de transición al estado "Postergado". No tiene efecto porque el turno fue cancelado.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Postergado(EstadoTurnoContexto contexto) { }
    }
}
