using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class Characteristic
{
    public int Id { get; set; }

    public string CharacteristicName { get; set; } = null!;

    public virtual ICollection<DisplayedCharacteristic> DisplayedCharacteristics { get; } = new List<DisplayedCharacteristic>();

    public virtual ICollection<ProductCharacteristic> ProductCharacteristics { get; } = new List<ProductCharacteristic>();

    public virtual ICollection<Category> Categories { get; } = new List<Category>();
}
