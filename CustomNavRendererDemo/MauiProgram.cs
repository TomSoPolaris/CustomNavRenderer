//using CustomNavRendererDemo.Platforms.Android;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace CustomNavRendererDemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCompatibility() // so we can use compatibility renderers
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureMauiHandlers((handlers) =>
			{
                // Try this using a ToolbarHandler Mapper instead
                //handlers.AddCompatibilityRenderer(typeof(NavigationPage), typeof(CustomNavRenderer));
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		ToolbarHandlerMapper.Initialize();

		return builder.Build();
	}
}

