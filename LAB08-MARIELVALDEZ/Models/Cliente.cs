using System;
using System.Collections.Generic;

namespace LAB08_MARIELVALDEZ.Models;

public partial class Cliente
{
    public int ClientId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Ordene> Ordenes { get; set; } = new List<Ordene>();
}
