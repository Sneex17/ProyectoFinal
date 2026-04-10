using System;
using System.Collections.Generic;

namespace CEntidades.Models;

public partial class Paciente
{
    public int PacienteId { get; set; }

    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Seguro { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
