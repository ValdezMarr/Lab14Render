using System;
using System.Collections.Generic;

namespace LAB08_MARIELVALDEZ.Models;

public partial class Producto
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<Ordendetalle> Ordendetalles { get; set; } = new List<Ordendetalle>();
}
