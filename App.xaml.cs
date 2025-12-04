namespace WeatherApp
{
    public partial class App : Application
    {

        public static Location? Location { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
