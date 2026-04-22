using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado "Creado" de un turno dentro del sistema.
    /// Desde este estado se pueden realizar transiciones a otros estados
    /// como En Atención, Cancelado o Postergado.
    /// Forma parte del patrón de diseño State.
    /// </summary>
    public class EstadoCreado: IEstadoTurno
    {
        public int EstadoTurnoId => 1;
        public string Nombre => "Creado";

        /// <summary>
        /// Acción cuando el turno ya está en estado creado.
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        public void Creado(EstadoTurnoContexto contexto) {}


        public void EnAtencion(EstadoTurnoContexto contexto)
        {
            contexto.CambioEstado(new EstadoEnAtencion());
        }
        /// <summary>
        /// Acción cuando se intenta marcar como atendido desde este estado.
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        public void Atendido(EstadoTurnoContexto contexto) { }

        /// <summary>
        /// Cambia el estado del turno a "Cancelado".
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        public void Cancelado(EstadoTurnoContexto contexto)
        {
            contexto.CambioEstado(new EstadoCancelado());
        }
        /// <summary>
        /// Cambia el estado del turno a "Postergado".
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        public void Postergado(EstadoTurnoContexto contexto) 
        {
            contexto.CambioEstado(new EstadoPostergado());
        }
    }
}
