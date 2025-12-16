using Microsoft.Extensions.Logging;
using Examen_Mvvm.ViewModels; 
using Examen_Mvvm;             

namespace Examen_Mvvm;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<Examen_MVVM.App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        
        // Registro de servicios MVVM
        builder.Services.AddSingleton<MainPage>(); 
        builder.Services.AddSingleton<MainViewModel>();

        return builder.Build();
    }
}