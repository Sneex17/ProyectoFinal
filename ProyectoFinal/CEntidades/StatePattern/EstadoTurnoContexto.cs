using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    public class EstadoTurnoContexto
    {
        public IEstadoTurno estado { get; private set; }
        public void CambioEstado(IEstadoTurno turno)
        {
            estado = turno;
        }

        public EstadoTurnoContexto()
        {
            estado = new EstadoCreado();
        }

        public void Creado() => estado.Creado(this);
        public void EnAtencion() => estado.EnAtencion(this);
        public void Atendido() => estado.Atendido(this);
        public void Cancelado() => estado.Cancelado(this);
        public void Postergado() => estado.Postergado(this);
    }
}
