using System;
using System.Collections.Generic;

namespace LAB08_MARIELVALDEZ.Models;

public partial class Ordendetalle
{
    public int OrderdetailId { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Ordene? Order { get; set; }

    public virtual Producto? Product { get; set; }
}
