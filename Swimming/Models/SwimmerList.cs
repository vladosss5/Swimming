using System;
using System.Collections.Generic;
using Swimming.ViewModels;

namespace Swimming.Models;

public partial class SwimmerList : ViewModelBase
{
    public int IdList { get; set; }

    public int IdSwim { get; set; }

    public int IdSwimmer { get; set; }

    public virtual Swim IdSwimNavigation { get; set; } = null!;

    public virtual Swimmer IdSwimmerNavigation { get; set; } = null!;
}
