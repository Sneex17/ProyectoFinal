using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Contexto central del patrón de estados para un turno.
    /// Mantiene una referencia al estado actual y delega todas las transiciones
    /// al objeto de estado correspondiente, permitiendo que el comportamiento
    /// cambie dinámicamente según el estado en que se encuentre el turno.
    /// </summary>
    public class EstadoTurnoContexto
    {
        /// <summary>
        /// Obtiene el estado actual del turno.
        /// Solo puede ser modificado internamente a través de <see cref="CambioEstado"/>.
        /// </summary>
        public IEstadoTurno estado { get; private set; }
        /// <summary>
        /// Reemplaza el estado actual del turno por el nuevo estado proporcionado.
        /// Este método es invocado por los propios estados durante una transición válida.
        /// </summary>
        /// <param name="turno">El nuevo estado al que transitará el turno.</param>
        public void CambioEstado(IEstadoTurno turno)
        {
            estado = turno;
        }
        /// <summary>
        /// Inicializa el contexto estableciendo "Creado" como estado inicial del turno,
        /// siguiendo el flujo natural del ciclo de vida de un turno.
        /// </summary>
        public EstadoTurnoContexto()
        {
            estado = new EstadoCreado();
        }
        /// <summary>
        /// Solicita la transición al estado "Creado" delegando al estado actual.
        /// El resultado depende de si el estado actual permite esta transición.
        /// </summary>
        public void Creado() => estado.Creado(this);
        /// <summary>
        /// Solicita la transición al estado "En Atención" delegando al estado actual.
        /// El resultado depende de si el estado actual permite esta transición.
        /// </summary>
        public void EnAtencion() => estado.EnAtencion(this);
        /// <summary>
        /// Solicita la transición al estado "Atendido" delegando al estado actual.
        /// El resultado depende de si el estado actual permite esta transición.
        /// </summary>
        public void Atendido() => estado.Atendido(this);
        /// <summary>
        /// Solicita la transición al estado "Cancelado" delegando al estado actual.
        /// El resultado depende de si el estado actual permite esta transición.
        /// </summary>
        public void Cancelado() => estado.Cancelado(this);
        /// <summary>
        /// Solicita la transición al estado "Postergado" delegando al estado actual.
        /// El resultado depende de si el estado actual permite esta transición.
        /// </summary>
        public void Postergado() => estado.Postergado(this);
    }
}
