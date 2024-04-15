using Microsoft.Extensions.Logging;
using TechStore.DataAccess;
using TechStore.ViewModels;

namespace TechStore;

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

		builder.Services.AddDbContext<TechStoreDbContext>();

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();

		// var dbContext = new TechStoreDbContext();
		// dbContext.Database.EnsureCreated();
		// dbContext.Dispose();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
