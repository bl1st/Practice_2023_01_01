using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<DisplayedCharacteristic> DisplayedCharacteristics { get; } = new List<DisplayedCharacteristic>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();

    public virtual ICollection<Characteristic> Characteristics { get; } = new List<Characteristic>();
}
