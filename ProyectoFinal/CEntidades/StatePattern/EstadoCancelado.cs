using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado "Cancelado" de un turno dentro del sistema.
    /// Forma parte del patrón de diseño State para controlar
    /// el comportamiento según el estado del turno.
    /// </summary>
    public class EstadoCancelado: IEstadoTurno
    {
        public int EstadoTurnoId => 4;
        public string Nombre => "Cancelado";
        public void Creado(EstadoTurnoContexto contexto) { }
        public void EnAtencion(EstadoTurnoContexto contexto) { }
        public void Atendido(EstadoTurnoContexto contexto) { }
        public void Cancelado(EstadoTurnoContexto contexto) { }
        public void Postergado(EstadoTurnoContexto contexto) { }
    }
}
