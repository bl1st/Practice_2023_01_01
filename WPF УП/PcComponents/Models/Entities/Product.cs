using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public decimal Price { get; set; }

    public short Discount { get; set; }

    public short MaximumDiscount { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderContent> OrderContents { get; } = new List<OrderContent>();

    public virtual ICollection<ProductCharacteristic> ProductCharacteristics { get; } = new List<ProductCharacteristic>();

    public virtual ICollection<ProductPicture> ProductPictures { get; } = new List<ProductPicture>();

    public virtual ICollection<ProductPrice> ProductPrices { get; } = new List<ProductPrice>();
}
