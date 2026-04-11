using System;
using System.Collections.Generic;

namespace CEntidades.Models;

public partial class Area
{
    public int AreaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<Recepcionista> Recepcionista { get; set; } = new List<Recepcionista>();
}
