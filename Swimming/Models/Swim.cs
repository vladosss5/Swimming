using System;
using System.Collections.Generic;
using Swimming.ViewModels;

namespace Swimming.Models;

public partial class Swim : ViewModelBase
{
    public int IdSwim { get; set; }

    public float? Distance { get; set; }
    public DateTime? DateAndTime { get; set; }
}
