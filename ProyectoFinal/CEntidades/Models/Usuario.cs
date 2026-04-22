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
    public int UsuarioId { get; set; }

    public string Usuario1 { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public int RolId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? UltimoAcceso { get; set; }

    public int EstadoId { get; set; }

    public virtual Estado Estado { get; set; } = null!;

    public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();

    public virtual ICollection<Recepcionista> Recepcionista { get; set; } = new List<Recepcionista>();

    public virtual Role Rol { get; set; } = null!;
}
