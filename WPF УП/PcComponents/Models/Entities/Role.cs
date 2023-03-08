using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class Role
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public bool? AllowAddProduct { get; set; }

    public bool? AllowDeleteProduct { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
