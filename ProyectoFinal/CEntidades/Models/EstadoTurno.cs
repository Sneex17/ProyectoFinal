using CEntidades.StatePattern;
using System;
using System.Collections.Generic;

namespace CEntidades.Models;

/// <summary>
/// Representa el estado de un turno dentro del sistema.
/// Permite identificar la situación del turno (por ejemplo: pendiente, confirmado, cancelado).
/// </summary>
public partial class EstadoTurno
{
    
    /// <summary>
    /// Identificador único del estado del turno.
    /// </summary>
    public int EstadoTurnoId { get; set; }

    /// <summary>
    /// Nombre del estado del turno.
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del estado del turno.
    /// </summary>          
    public string? Descripcion { get; set; }

        /// <summary> 
        /// Colección de turnos que tienen este estado.
        /// </summary>
    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
