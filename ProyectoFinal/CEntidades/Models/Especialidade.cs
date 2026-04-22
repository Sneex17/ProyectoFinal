using System;
using System.Collections.Generic;

namespace CEntidades.Models;

/// <summary>
/// Representa una especialidad médica dentro del sistema.
/// Contiene información básica como el nombre, descripción
/// y la relación con los médicos que pertenecen a esta especialidad.
/// </summary>
public partial class Especialidade
{
    /// <summary>
    /// Identificador único de la especialidad.
    /// </summary>
    public int EspecialidadId { get; set; }

    /// <summary>
    /// Nombre de la especialidad.
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción de la especialidad.
    /// </summary>  
    public string? Descripcion { get; set; }
    
    /// <summary>
    /// Colección de médicos que pertenecen a esta especialidad.
    /// </summary>
    public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();
}
