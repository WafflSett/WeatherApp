using CommunityToolkit.Maui.Views;

namespace WeatherApp.PopUps;

public partial class LocationInputPopup : Popup
{
    public string LocationStr { get; set; }
    public LocationInputPopup()
	{
		InitializeComponent();
        this.BindingContext = this;
	}

    private void save_BTN_Clicked(object sender, EventArgs e)
    {

    }

    private void cancel_BTN_Clicked(object sender, EventArgs e)
    {
        this.CloseAsync();
    }
}