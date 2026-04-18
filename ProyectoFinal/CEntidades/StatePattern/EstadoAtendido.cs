using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
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
