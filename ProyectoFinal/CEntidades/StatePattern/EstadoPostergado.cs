using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    public class EstadoPostergado: IEstadoTurno
    {
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
