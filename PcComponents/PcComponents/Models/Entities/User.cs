using System;
using System.Collections.Generic;

namespace PcComponents.Models.Entities;

public partial class User
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public string Surename { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
