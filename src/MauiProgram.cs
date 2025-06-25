using CommunityToolkit.Maui;
using Discord.Video.Trimmer.ViewModels;
using Microsoft.Extensions.Logging;

namespace Discord.Video.Trimmer;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
               .UseMauiCommunityToolkitMediaElement()
               .ConfigureFonts(fonts =>
               {
                   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
               });

        builder.Services.AddSingleton<MainViewModel>()
                        .AddSingleton<MainPageView>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}