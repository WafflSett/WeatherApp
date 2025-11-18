using WeatherApp.ViewModels;

namespace WeatherApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel VM)
        {
            InitializeComponent();
            this.BindingContext = VM;
        }

    }

}
