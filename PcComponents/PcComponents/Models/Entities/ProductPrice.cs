using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class ProductPrice
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public decimal Price { get; set; }

    public virtual Product Product { get; set; } = null!;
}
