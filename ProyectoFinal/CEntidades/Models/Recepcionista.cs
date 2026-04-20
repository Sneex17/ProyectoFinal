using System;
using System.Collections.Generic;

namespace CEntidades.Models;

public partial class Recepcionista
{
    public int RecepcionistaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int AreaId { get; set; }

    public int UsuarioId { get; set; }

    public int EstadoId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual Estado Estado { get; set; } = null!;

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    public virtual Usuario Usuario { get; set; } = null!;
}
