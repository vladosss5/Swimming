using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Swimming.ViewModels;

namespace Swimming.Views;

public partial class ListHeatsView : Window
{
    public ListHeatsView()
    {
        DataContext = new ListHeatsVM();
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}