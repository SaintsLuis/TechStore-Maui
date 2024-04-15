using TechStore.DataAccess;
using TechStore.ViewModels;

namespace TechStore;

public partial class MainPage : ContentPage
{

	public MainPage()
	{

		InitializeComponent();

		var serviceProvider = MauiProgram.CreateMauiApp().Services;
		var dbContext = serviceProvider.GetRequiredService<TechStoreDbContext>();

		BindingContext = new MainPageViewModel(dbContext);

	}

}

