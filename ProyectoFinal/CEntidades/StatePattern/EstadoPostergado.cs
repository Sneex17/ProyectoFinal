using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado "Postergado" de un turno dentro del sistema.
    /// Desde este estado el turno puede volver a "Creado" o ser cancelado.
    /// Forma parte del patrón de diseño State.
    /// </summary>
    public class EstadoPostergado: IEstadoTurno
    {
        /// <summary>
        /// Identificador del estado "Postergado".
        /// </summary>
        public int EstadoTurnoId => 5;
        public string Nombre => "Postergado";
        public void Creado(EstadoTurnoContexto contexto) 
        {
            contexto.CambioEstado(new EstadoCreado());
        }
        public void EnAtencion(EstadoTurnoContexto contexto) { }
        public void Atendido(EstadoTurnoContexto contexto) { }
        public void Cancelado(EstadoTurnoContexto contexto)
        {
            contexto.CambioEstado(new EstadoCancelado());
        }
        public void Postergado(EstadoTurnoContexto contexto) { }
    }
}
