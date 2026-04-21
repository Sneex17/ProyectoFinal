using System;
using System.Collections.Generic;

namespace CEntidades.Models;

public partial class EstadoTurno
{
    public int EstadoTurnoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
