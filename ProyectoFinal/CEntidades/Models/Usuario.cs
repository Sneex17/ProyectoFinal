using System;
using System.Collections.Generic;

namespace CEntidades.Models;
/// <summary>
/// Representa un usuario dentro del sistema.
/// Contiene las credenciales de acceso, rol, estado
/// y las relaciones con médicos y recepcionistas.
/// </summary>

public partial class Usuario
{
    /// <summary>
    /// Identificador único del usuario.
    /// </summary>
    public int UsuarioId { get; set; }

    /// <summary>
    /// Nombre de usuario para el inicio de sesión.
    /// </summary>
    public string Usuario1 { get; set; } = null!;

    /// <summary>
    /// Contraseña del usuario.
    /// </summary>
    public string Contrasena { get; set; } = null!;

    /// <summary>
    /// Identificador del rol asignado al usuario.
    /// </summary>
    public int RolId { get; set; }

    /// <summary>
    /// Fecha de creación del usuario.
    /// </summary>
    public DateTime? FechaCreacion { get; set; }

    /// <summary>
    /// Fecha del último acceso del usuario.
    /// </summary>
    public DateTime? UltimoAcceso { get; set; }

    /// <summary>
    /// Identificador del estado del usuario.
    /// </summary>
    public int EstadoId { get; set; }

    /// <summary>
    /// Estado actual del usuario.
    /// </summary>
    public virtual Estado Estado { get; set; } = null!;

    /// <summary>
    /// Colección de médicos asociados al usuario.
    /// </summary>
    public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();

    /// <summary>
    /// Colección de recepcionistas asociados al usuario.
    /// </summary>
    public virtual ICollection<Recepcionista> Recepcionista { get; set; } = new List<Recepcionista>();

    /// <summary>
    /// Rol asignado al usuario.
    /// </summary>
    public virtual Role Rol { get; set; } = null!;
}
