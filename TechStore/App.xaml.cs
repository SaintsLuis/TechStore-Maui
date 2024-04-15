using TechStore.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace TechStore;

public partial class App : Application
{

	public App()
	{
		InitializeComponent();

		var serviceProvider = MauiProgram.CreateMauiApp().Services;
		var dbContext = serviceProvider.GetRequiredService<TechStoreDbContext>();

		try
		{

			var dbInitializer = new DatabaseInitializer(dbContext);
			dbInitializer.Initialize();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

		MainPage = new AppShell();
	}
}
