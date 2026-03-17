using System;
using System.Collections.Generic;

namespace Group4337.Models;

public partial class User
{
    public int Id { get; set; }

    public string Post { get; set; } = null!;

    public string UserLogin { get; set; } = null!;
}
