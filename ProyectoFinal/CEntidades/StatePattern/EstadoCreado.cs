using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado inicial "Creado" dentro del patrón de estados para un turno.
    /// Desde este estado, el turno puede avanzar a "En Atención", ser "Cancelado" o "Postergado".
    /// </summary>
    public class EstadoCreado: IEstadoTurno
    {
        /// <summary>
        /// Obtiene el identificador numérico del estado. Corresponde al valor 1 (Creado).
        /// </summary>
        public int EstadoTurnoId => 1;
        /// <summary>
        /// Obtiene el nombre descriptivo del estado actual.
        /// </summary>
        public string Nombre => "Creado";
        /// <summary>
        /// Intento de transición al estado "Creado". No tiene efecto porque el turno ya se encuentra en este estado.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Creado(EstadoTurnoContexto contexto) {}
        /// <summary>
        /// Realiza la transición al estado "En Atención", indicando que el turno comenzó a ser procesado.
        /// </summary>
        /// <param name="contexto">El contexto del turno que gestionará el nuevo estado.</param>
        public void EnAtencion(EstadoTurnoContexto contexto)
        {
            contexto.CambioEstado(new EstadoEnAtencion());
        }
        /// <summary>
        /// Intento de transición al estado "Atendido". No tiene efecto porque el turno aún no ha sido atendido.
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Atendido(EstadoTurnoContexto contexto) { }
        /// <summary>
        /// Intento de transición al estado "Atendido". No tiene efecto porque el turno aún no ha sido atendido.
        /// La transición válida previa es "En Atención".
        /// </summary>
        /// <param name="contexto">El contexto del turno sobre el que se aplica la transición.</param>
        public void Cancelado(EstadoTurnoContexto contexto)
        {
            contexto.CambioEstado(new EstadoCancelado());
        }
        /// <summary>
        /// Realiza la transición al estado "Postergado", indicando que el turno ha sido pospuesto.
        /// </summary>
        /// <param name="contexto">El contexto del turno que gestionará el nuevo estado.</param>
        public void Postergado(EstadoTurnoContexto contexto) 
        {
            contexto.CambioEstado(new EstadoPostergado());
        }
    }
}
