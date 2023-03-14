using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class DisplayedCharacteristic
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public int? CharacteristicId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Characteristic? Characteristic { get; set; }
}
