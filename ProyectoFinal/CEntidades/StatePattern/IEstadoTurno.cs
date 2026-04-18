using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    public interface IEstadoTurno
    {
        int EstadoTurnoId { get; }
        string Nombre { get; }
        void Creado(EstadoTurnoContexto contexto);
        void EnAtencion(EstadoTurnoContexto contexto);
        void Atendido(EstadoTurnoContexto contexto);
        void Cancelado(EstadoTurnoContexto contexto);
        void Postergado(EstadoTurnoContexto contexto);
    }
}
