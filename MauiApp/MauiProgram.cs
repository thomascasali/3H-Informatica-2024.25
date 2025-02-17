using Microsoft.Extensions.Logging;

namespace MauiApp
{
    public static class MauiProgram
    {
        public static Microsoft.Maui.MauiApp CreateMauiApp()
        {
            var builder = Microsoft.Maui.MauiApp.CreateBuilder();
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

            return builder.Build();
        }
    }
}
