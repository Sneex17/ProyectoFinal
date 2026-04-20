using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado "En Atención" dentro del patrón de estados para un turno.
    /// En este estado, el turno se encuentra siendo procesado activamente y solo puede
    /// avanzar al estado final "Atendido".
    /// </summary>
    public class EstadoEnAtencion: IEstadoTurno
    {
        /// <summary>
        /// Obtiene el identificador numérico del estado. Corresponde al valor 2 (En Atención).
        /// </summary>
        public int EstadoTurnoId => 2;
        /// <summary>
        /// Obtiene el nombre descriptivo del estado actual.
        /// </summary>
        public string Nombre => "En Atencion";
        /// <summary>
        /// Intento de transición al estado "Creado". No tiene efecto porque el turno
        /// ya inició su atención y no puede retroceder a su estado inicial.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Creado(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Intento de transición al estado "En Atención". No tiene efecto porque
        /// el turno ya se encuentra en este estado.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void EnAtencion(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Realiza la transición al estado "Atendido", indicando que el turno fue
        /// procesado satisfactoriamente y completó su ciclo de atención.
        /// </summary>
        /// <param name="contexto">El contexto del turno que gestionará el nuevo estado.</param>
        public void Atendido(EstadoTurnoContexto contexto) 
        {
            contexto.CambioEstado(new EstadoAtendido());
        }
        /// <summary>
        /// Intento de transición al estado "Cancelado". No tiene efecto porque
        /// un turno en atención activa no puede ser cancelado directamente.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Cancelado(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Intento de transición al estado "Postergado". No tiene efecto porque
        /// un turno en atención activa no puede ser diferido nuevamente.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Postergado(EstadoTurnoContexto contexto) { }
    }
}
