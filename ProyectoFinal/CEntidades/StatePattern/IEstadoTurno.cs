using CEntidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.StatePattern
{
    /// <summary>
    /// Define el contrato que deben implementar todos los estados posibles de un turno
    /// dentro del patrón de estados (State Pattern).
    /// Cada implementación determina qué transiciones son válidas desde ese estado
    /// y cuáles deben ser ignoradas silenciosamente.
    /// </summary>
    /// <remarks>
    /// Los estados concretos que implementan esta interfaz son:
    /// <list type="bullet">
    ///     <item><description><see cref="EstadoCreado"/> — Estado inicial del turno (Id: 1).</description></item>
    ///     <item><description><see cref="EstadoEnAtencion"/> — Turno siendo procesado activamente (Id: 2).</description></item>
    ///     <item><description><see cref="EstadoAtendido"/> — Estado terminal: turno completado (Id: 3).</description></item>
    ///     <item><description><see cref="EstadoCancelado"/> — Estado terminal: turno anulado (Id: 4).</description></item>
    ///     <item><description><see cref="EstadoPostergado"/> — Turno diferido, puede reactivarse (Id: 5).</description></item>
    /// </list>
    /// </remarks>
    public interface IEstadoTurno
    {
        /// <summary>
        /// Obtiene el identificador numérico único que representa este estado en el sistema.
        /// </summary>
        int EstadoTurnoId { get; }
        /// <summary>
        /// Obtiene el nombre descriptivo del estado, utilizado para presentación y registro.
        /// </summary>
        string Nombre { get; }
        /// <summary>
        /// Maneja la solicitud de transición al estado "Creado".
        /// Las implementaciones deciden si esta transición es válida desde su estado actual.
        /// </summary>
        /// <param name="contexto">
        /// El contexto del turno que será actualizado si la transición es permitida.
        /// </param>
        void Creado(EstadoTurnoContexto contexto);
        /// <summary>
        /// Maneja la solicitud de transición al estado "En Atención".
        /// Las implementaciones deciden si esta transición es válida desde su estado actual.
        /// </summary>
        /// <param name="contexto">
        /// El contexto del turno que será actualizado si la transición es permitida.
        /// </param>
        void EnAtencion(EstadoTurnoContexto contexto);
        /// <summary>
        /// Maneja la solicitud de transición al estado "Atendido".
        /// Las implementaciones deciden si esta transición es válida desde su estado actual.
        /// </summary>
        /// <param name="contexto">
        /// El contexto del turno que será actualizado si la transición es permitida.
        /// </param>
        void Atendido(EstadoTurnoContexto contexto);
        /// <summary>
        /// Maneja la solicitud de transición al estado "Cancelado".
        /// Las implementaciones deciden si esta transición es válida desde su estado actual.
        /// </summary>
        /// <param name="contexto">
        /// El contexto del turno que será actualizado si la transición es permitida.
        /// </param>
        void Cancelado(EstadoTurnoContexto contexto);
        /// <summary>
        /// Maneja la solicitud de transición al estado "Postergado".
        /// Las implementaciones deciden si esta transición es válida desde su estado actual.
        /// </summary>
        /// <param name="contexto">
        /// El contexto del turno que será actualizado si la transición es permitida.
        /// </param>
        void Postergado(EstadoTurnoContexto contexto);
    }
}
