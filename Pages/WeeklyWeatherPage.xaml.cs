using WeatherApp.ViewModels;

namespace WeatherApp.Pages;

public partial class WeeklyWeatherPage : ContentPage
{
	public WeeklyWeatherPage(WeeklyWeatherViewModel VM)
	{
		InitializeComponent();
		this.BindingContext = VM;
	}
}