using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using ReactiveUI;
using Swimming.Models;
using System.Reactive;
using Avalonia.Controls;
using Swimming;
using Swimming.Context;

namespace Swimming.ViewModels;

public class ListHeatsVM : ViewModelBase
{
    private ObservableCollection<Swim> _swim;
    private Swim _swims = new Swim();
    private MyDbContext db = new MyDbContext();
    
    public ObservableCollection<Swim> Swim
    {
        get => _swim;
        set => this.RaiseAndSetIfChanged(ref _swim, value);
    }

    public ListHeatsVM()
    {
        Swim = new ObservableCollection<Swim>(Helper.GetContext().Swims.ToList());
    }
}