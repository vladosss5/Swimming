using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Swimming.ViewModels;
using Swimming.Views;

namespace Swimming;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new ListHeatsView()
            {
                DataContext = new ListHeatsVM(),
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}