using System;
using System.Collections.Generic;

namespace CEntidades.Models;
/// <summary>
/// Representa un médico dentro del sistema.
/// Contiene información personal, su especialidad y el usuario asociado,
/// además de los turnos que tiene asignados.
/// </summary>
public partial class Medico

{
    /// <summary>
    /// Identificador único del médico.
    /// </summary>
    public int MedicoId { get; set; }

    /// <summary>
    /// Número de licencia del médico.
    /// </summary>  
    public string Nlicencia { get; set; } = null!;
    /// <summary>
    /// Nombre del médico.
    /// </summary>
    public string Nombre { get; set; } = null!;
    
    /// <summary>
    /// Apellido del médico.
    /// </summary>
    public string Apellido { get; set; } = null!;

    /// <summary>
    /// Identificador de la especialidad del médico.
    /// </summary>

    public int EspecialidadId { get; set; }
    
    /// <summary>
    /// Identificador del usuario asociado al médico.
    /// </summary>
    public int UsuarioId { get; set; }

    /// <summary>
    /// Identificador del estado del médico.
    /// </summary>
    public int EstadoId { get; set; }

    /// <summary>
    /// Especialidad a la que pertenece el médico.
    /// </summary>

    public virtual Especialidade Especialidad { get; set; } = null!;

    /// <summary>
    /// Estado actual del médico.
    /// </summary>
    public virtual Estado Estado { get; set; } = null!;
    
    /// <summary>
    /// Colección de turnos asignados al médico.
    /// </summary>
    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    
    /// <summary>
    /// Usuario asociado al médico.
    /// </summary>
    public virtual Usuario Usuario { get; set; } = null!;
    
    /// <summary>
    /// Nombre completo del médico.
    /// </summary>
    public string NombreCompleto => $"{Nombre} {Apellido}";
}
