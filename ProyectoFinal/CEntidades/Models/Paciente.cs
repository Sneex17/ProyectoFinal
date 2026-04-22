using System;
using System.Collections.Generic;

namespace CEntidades.Models;

/// <summary>
/// Representa un paciente dentro del sistema.
/// Contiene información personal y de contacto,
/// además de los turnos asociados.
/// </summary>

public partial class Paciente
{
    /// <summary>
    /// Identificador único del paciente.
    /// </summary>
    public int PacienteId { get; set; }

    /// <summary>
    /// Número de cédula del paciente.
    /// </summary>

    public string Cedula { get; set; } = null!;

    /// <summary>
    /// Nombre del paciente.
    /// </summary>
    public string Nombre { get; set; } = null!;

    /// <summary>
    /// Apellido del paciente.
    /// </summary>
    public string Apellido { get; set; } = null!;

    /// <summary>
    /// Fecha de nacimiento del paciente.
    /// </summary>          
   
    public DateOnly FechaNacimiento { get; set; }
    
    /// <summary>
    /// Sexo del paciente.
    /// </summary>
    public string Sexo { get; set; } = null!;

    /// <summary>
    /// Dirección del paciente.
    /// </summary>
    public string? Direccion { get; set; }

    /// <summary>
    /// Información del seguro del paciente.
    /// </summary>
    public string? Seguro { get; set; }

    /// <summary>
    /// Correo electrónico del paciente.
    /// </summary>
    public string? Correo { get; set; }

    /// <summary>
    /// Colección de turnos asociados al paciente.
    /// </summary>
    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    /// <summary>
    /// Nombre completo del paciente.
    /// </summary>
    public string NombreCompleto => $"{Nombre} {Apellido}";
}
