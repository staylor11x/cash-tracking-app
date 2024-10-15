using CashTrackingApp.Repository;
using CashTrackingApp.Service;
using CashTrackingApp.ViewModels;
using CashTrackingApp.Views;
using Microsoft.Extensions.Logging;

namespace CashTrackingApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        //Register the service so you dont have to instansiate later
        builder.Services.AddSingleton<ICashRepository, CashRepository>();
        builder.Services.AddSingleton<ICashService, CashService>();
        builder.Services.AddTransient<CashViewModel>();

        //Register the page(s) for DI
        builder.Services.AddTransient<CashBalancePage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
