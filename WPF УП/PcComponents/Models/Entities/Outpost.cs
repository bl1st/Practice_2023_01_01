using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class Outpost
{
    public int Id { get; set; }

    public string Address { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
