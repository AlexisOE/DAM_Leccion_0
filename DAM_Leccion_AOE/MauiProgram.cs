using Microsoft.Extensions.Logging;

namespace DAM_Leccion_AOE
{
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
            builder.ConfigureMauiHandlers(handlers => { });
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
