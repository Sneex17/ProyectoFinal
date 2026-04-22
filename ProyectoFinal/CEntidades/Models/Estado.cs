using System;
using System.Collections.Generic;

namespace CEntidades.Models;
/// <summary>
/// Representa un estado dentro del sistema.
/// Puede indicar la condición o situación de un usuario
/// (por ejemplo: activo, inactivo, suspendido).
/// </summary>
public partial class Estado
{
    /// <summary>
    /// Identificador único del estado.
    /// </summary>
    public int EstadoId { get; set; }

    /// <summary>
    /// Nombre del estado.
    /// </summary>  
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del estado.
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary> 
    /// Colección de usuarios que tienen este estado.
    /// </summary>
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    /// <summary>
    /// Colección de médicos que tienen este estado.
    /// </summary>
    public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();

    /// <summary>
    /// Colección de recepcionistas que tienen este estado.
    /// </summary>
    public virtual ICollection<Recepcionista> Recepcionista { get; set; } = new List<Recepcionista>();
}
