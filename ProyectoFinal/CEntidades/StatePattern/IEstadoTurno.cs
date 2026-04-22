using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Define el contrato para los estados de un turno.
    /// Forma parte del patrón de diseño State y establece
    /// las operaciones que cada estado concreto debe implementar.
    /// </summary>
    public interface IEstadoTurno
    {
        /// <summary>
        /// Identificador del estado del turno.
        /// </summary>
        int EstadoTurnoId { get; }

        /// <summary>
        /// Nombre del estado del turno.
        /// </summary>
        string Nombre { get; }

        /// <summary>
        /// Acción correspondiente al estado "Creado".
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>

        void Creado(EstadoTurnoContexto contexto);

        /// <summary>
        /// Acción correspondiente al estado "En Atención".
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        void EnAtencion(EstadoTurnoContexto contexto);

        /// <summary>
        /// Acción correspondiente al estado "Atendido".
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        void Atendido(EstadoTurnoContexto contexto);

        /// <summary>
        /// Acción correspondiente al estado "Cancelado".
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        void Cancelado(EstadoTurnoContexto contexto);

        /// <summary>
        /// Acción correspondiente al estado "Postergado".
        /// </summary>
        /// <param name="contexto">Contexto del estado del turno.</param>
        void Postergado(EstadoTurnoContexto contexto);
    }
}
