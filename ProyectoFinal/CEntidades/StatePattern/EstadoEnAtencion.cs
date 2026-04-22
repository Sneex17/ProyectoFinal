using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado "En Atención" de un turno dentro del sistema.
    /// Desde este estado el turno puede ser marcado como atendido.
    /// Forma parte del patrón de diseño State.
    /// </summary>
    public class EstadoEnAtencion: IEstadoTurno
    {
        public int EstadoTurnoId => 2;
        public string Nombre => "En Atencion";

        /// <summary>
        /// Acción cuando el turno está en estado creado.
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        public void Creado(EstadoTurnoContexto contexto) { }
        public void EnAtencion(EstadoTurnoContexto contexto) { }
        
        public void Atendido(EstadoTurnoContexto contexto) 
        {
            contexto.CambioEstado(new EstadoAtendido());
        }

        /// <summary>
        /// Acción cuando el turno es cancelado.
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        public void Cancelado(EstadoTurnoContexto contexto) { }
        public void Postergado(EstadoTurnoContexto contexto) { }
    }
}
