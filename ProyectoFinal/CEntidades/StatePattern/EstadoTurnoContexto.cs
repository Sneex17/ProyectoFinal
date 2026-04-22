using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Representa el contexto del estado de un turno.
    /// Gestiona el estado actual y delega el comportamiento
    /// a las clases concretas del patrón State.
    /// </summary>

    public class EstadoTurnoContexto
    {
        /// <summary>
        /// Estado actual del turno.
        /// </summary>
        public IEstadoTurno estado { get; private set; }
        /// <summary>
        /// Cambia el estado actual del turno.
        /// </summary>
        /// <param name="turno">Nuevo estado a asignar.</param>
        public void CambioEstado(IEstadoTurno turno)
        {
            estado = turno;
        }

        /// <summary>
        /// Inicializa el contexto con el estado "Creado".
        /// </summary>
        public EstadoTurnoContexto()
        {
            estado = new EstadoCreado();
        }

        /// <summary>
        /// Ejecuta las acciones correspondientes al estado actual del turno,
        /// delegando el comportamiento a la implementación concreta del patrón State.
        /// Cada método invoca la operación definida en el estado actual.
        /// </summary>
        public void Creado() => estado.Creado(this);
        public void EnAtencion() => estado.EnAtencion(this);
        public void Atendido() => estado.Atendido(this);
        public void Cancelado() => estado.Cancelado(this);
        public void Postergado() => estado.Postergado(this);
    }
}
