using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    public class EstadoEnAtencion: IEstadoTurno
    {
        public int EstadoTurnoId => 2;
        public string Nombre => "En Atencion";
        public void Creado(EstadoTurnoContexto contexto) { }
        public void EnAtencion(EstadoTurnoContexto contexto) { }
        
        public void Atendido(EstadoTurnoContexto contexto) 
        {
            contexto.CambioEstado(new EstadoAtendido());
        }
        public void Cancelado(EstadoTurnoContexto contexto) { }
        public void Postergado(EstadoTurnoContexto contexto) { }
    }
}
