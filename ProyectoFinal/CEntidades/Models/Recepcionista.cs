using System;
using System.Collections.Generic;

namespace CEntidades.Models;

/// <summary>
/// Representa un recepcionista dentro del sistema.
/// Contiene información personal, el área donde trabaja
/// y el usuario asociado, además de los turnos que gestiona.
/// </summary>
public partial class Recepcionista
{
    /// <summary>
    /// Identificador único del recepcionista.
    /// </summary>
    public int RecepcionistaId { get; set; }

    /// <summary>
    /// Nombre del recepcionista.
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Apellido del recepcionista.
    /// </summary>
    public string Apellido { get; set; } = null!;

    /// <summary>
    /// Identificador del área donde trabaja el recepcionista.
    /// </summary>
    public int AreaId { get; set; }
    
    /// <summary>
    /// Identificador del usuario asociado al recepcionista.
    /// </summary>
    public int UsuarioId { get; set; }

    /// <summary>
    /// Área donde trabaja el recepcionista.
    /// </summary>
    public virtual Area Area { get; set; } = null!;

    /// <summary>
    /// Colección de turnos gestionados por el recepcionista.
    /// </summary>  
    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    
    /// <summary>
    /// Usuario asociado al recepcionista.
    /// </summary>
    public virtual Usuario Usuario { get; set; } = null!;
}
