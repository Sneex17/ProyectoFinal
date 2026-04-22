using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el estado "Atendido" de un turno dentro del sistema.
    /// Forma parte del patrón de diseño State para gestionar los cambios de estado de un turno.
    /// </summary>
    public class EstadoAtendido:IEstadoTurno
    {
        public int EstadoTurnoId => 3;
        public string Nombre => "Atendido";
        public void Creado(EstadoTurnoContexto contexto) { }
        public void EnAtencion(EstadoTurnoContexto contextoo) { }
        public void Atendido(EstadoTurnoContexto contexto) { }
        public void Cancelado(EstadoTurnoContexto contexto) { }
        public void Postergado(EstadoTurnoContexto contexto) { }
    }
}
