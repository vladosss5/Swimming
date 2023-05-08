using System;
using System.Collections.Generic;
using Swimming.ViewModels;

namespace Swimming.Models;

public partial class Swimmer : ViewModelBase
{
    public int IdSwimmer { get; set; }

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string? Lname { get; set; }
}
