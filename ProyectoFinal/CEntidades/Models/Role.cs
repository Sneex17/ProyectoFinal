using System;
using System.Collections.Generic;

namespace CEntidades.Models;
/// <summary>
/// Representa un rol dentro del sistema.
/// Define los permisos o tipo de usuario (por ejemplo: administrador, recepcionista, médico).
/// </summary>
public partial class Role
{
    /// <summary>  
    /// Identificador único del rol.
    /// </summary>
    public int RolId { get; set; }

    /// <summary>
    /// Nombre del rol.
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Descripción del rol.
    /// </summary>
    public string? Descripcion { get; set; }

    /// <summary>
    /// Colección de usuarios asociados a este rol.
    /// </summary>
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
