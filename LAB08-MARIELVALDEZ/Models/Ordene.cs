using System;
using System.Collections.Generic;

namespace LAB08_MARIELVALDEZ.Models;

public partial class Ordene
{
    public int OrderId { get; set; }

    public int? ClientId { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual Cliente? Client { get; set; }

    public virtual ICollection<Ordendetalle> Ordendetalles { get; set; } = new List<Ordendetalle>();
}
