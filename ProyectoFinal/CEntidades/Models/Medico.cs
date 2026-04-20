using System;
using System.Collections.Generic;

namespace CEntidades.Models;

public partial class Medico
{
    public int MedicoId { get; set; }

    public string Nlicencia { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int EspecialidadId { get; set; }

    public int UsuarioId { get; set; }

    public virtual Especialidade Especialidad { get; set; } = null!;

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    public virtual Usuario Usuario { get; set; } = null!;

    public string NombreCompleto => $"{Nombre} {Apellido}";
}
