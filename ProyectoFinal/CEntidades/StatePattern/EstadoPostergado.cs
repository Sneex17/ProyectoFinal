using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado "Postergado" dentro del patrón de estados para un turno.
    /// Un turno postergado fue diferido temporalmente y puede ser reactivado regresando
    /// al estado "Creado", o bien ser descartado transitando al estado "Cancelado".
    /// </summary>
    public class EstadoPostergado: IEstadoTurno
    {
        /// <summary>
        /// Obtiene el identificador numérico del estado. Corresponde al valor 5 (Postergado).
        /// </summary>
        public int EstadoTurnoId => 5;
        /// <summary>
        /// Obtiene el nombre descriptivo del estado actual.
        /// </summary>
        public string Nombre => "Postergado";
        /// <summary>
        /// Realiza la transición al estado "Creado", reactivando el turno postergado
        /// y devolviéndolo al inicio del flujo para ser atendido nuevamente.
        /// </summary>
        /// <param name="contexto">El contexto del turno que gestionará el nuevo estado.</param>
        public void Creado(EstadoTurnoContexto contexto) 
        {
            contexto.CambioEstado(new EstadoCreado());
        }
        /// <summary>
        /// Intento de transición al estado "En Atención". No tiene efecto porque
        /// un turno postergado debe pasar primero por el estado "Creado" antes de ser atendido.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void EnAtencion(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Intento de transición al estado "Atendido". No tiene efecto porque
        /// un turno postergado no puede marcarse como atendido sin haber pasado por "En Atención".
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Atendido(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Realiza la transición al estado "Cancelado", descartando definitivamente
        /// el turno que se encontraba postergado.
        /// </summary>
        /// <param name="contexto">El contexto del turno que gestionará el nuevo estado.</param>
        public void Cancelado(EstadoTurnoContexto contexto)
        {
            contexto.CambioEstado(new EstadoCancelado());
        }
        /// <summary>
        /// Intento de transición al estado "Postergado". No tiene efecto porque
        /// el turno ya se encuentra en este estado.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Postergado(EstadoTurnoContexto contexto) { }
    }
}
