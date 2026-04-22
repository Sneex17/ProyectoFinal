using System;
using System.Collections.Generic;

namespace CEntidades.Models;
/// <summary>
/// Representa un área dentro del sistema.
/// Contiene información básica como nombre, descripción
/// y la relación con los recepcionistas asignados.
/// </summary>
public partial class Area
{
    /// <summary>
    /// Identificador único del área.
    /// </summary>
    public int AreaId { get; set; }

    /// <summary>
    /// Nombre del área.
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del área.
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Colección de recepcionistas asignados al área.
    /// </summary>
    public virtual ICollection<Recepcionista> Recepcionista { get; set; } = new List<Recepcionista>();
}
