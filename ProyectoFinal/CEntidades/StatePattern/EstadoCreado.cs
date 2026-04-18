using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    public class EstadoCreado: IEstadoTurno
    {
        public int EstadoTurnoId => 1;
        public string Nombre => "Creado";
        public void Creado(EstadoTurnoContexto contexto) {}
        public void EnAtencion(EstadoTurnoContexto contexto)
        {
            contexto.CambioEstado(new EstadoEnAtencion());
        }
        public void Atendido(EstadoTurnoContexto contexto) { }
        public void Cancelado(EstadoTurnoContexto contexto)
        {
            contexto.CambioEstado(new EstadoCancelado());
        }
        public void Postergado(EstadoTurnoContexto contexto) 
        {
            contexto.CambioEstado(new EstadoPostergado());
        }
    }
}
