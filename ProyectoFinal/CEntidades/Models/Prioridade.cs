using System;
using System.Collections.Generic;

namespace CEntidades.Models;
/// <summary>
/// Representa el nivel de prioridad de un turno dentro del sistema.
/// Permite clasificar los turnos según su urgencia.
/// </summary>
public partial class Prioridade
{
    /// <summary>
    /// Identificador único de la prioridad.
    /// </summary>
    public int PrioridadId { get; set; }

    /// <summary>
    /// Nombre de la prioridad.
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la prioridad.
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Colección de turnos asociados a esta prioridad.
    /// </summary>
    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
