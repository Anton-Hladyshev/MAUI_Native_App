using AntonLeoApp.Model.Services;
using AntonLeoApp.ViewModels;
using Microsoft.Extensions.Logging;

namespace AntonLeoApp;

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

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSingleton<CharacterService>();
        
        builder.Services.AddTransient<CharactersViewModel>();
        builder.Services.AddTransient<CharactersPage>();

        return builder.Build();
    }
}