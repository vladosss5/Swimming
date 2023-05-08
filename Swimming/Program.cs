using Avalonia;
using Avalonia.ReactiveUI;
using System;
using Avalonia.Controls;
using Swimming.Context;
using Swimming.Views;

namespace Swimming;

class Program
{
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace()
            .UseReactiveUI();
    private static void AppMain(Application app, string[] args)
    {
        var window = new ListHeatsView()
        {
            DataContext = new MyDbContext(),
        };

        app.Run(window);
    }
}