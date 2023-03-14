using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class ProductPicture
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public byte[]? Picture { get; set; }

    public virtual Product? Product { get; set; }
}
