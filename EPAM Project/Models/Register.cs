using System;
using System.Collections.Generic;

namespace EPAM_Project.Models;

public partial class Register
{
    public int Uid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
