using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.PopUps;

namespace WeatherApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
		[ObservableProperty]
		Location? locationData;

        [ObservableProperty]
        string cityName = "Location";

        [ObservableProperty]
        bool isLoaderVisible = false;

        [RelayCommand]
        private async Task GetLocation() {
            IsLoaderVisible = true;
            try
            {
                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                LocationData = await Geolocation.Default.GetLocationAsync(request);
                if (LocationData != null)
                {
                    CityName = await GetGeoDecoder(LocationData.Latitude, LocationData.Longitude);
                }
            }
            catch (FeatureNotSupportedException ex)
            {
                await Shell.Current.DisplayAlert("Error", $"Location is not supported on this device! \nError: {ex}", "Ok");
            }
            catch (FeatureNotEnabledException ex)
            {
                await Shell.Current.DisplayAlert("Error", $"Location is not enabled on this device! \nError: {ex}", "Ok");
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"Locating the phone was unsuccessful, please try again! \nError {ex}", "Ok");
            }
            IsLoaderVisible = false;
        }
        private async Task<string?> GetGeoDecoder(double lat, double lon) {
            IEnumerable<Placemark> placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);
            Placemark? placemark = placemarks.FirstOrDefault();
            if (placemark!=null)
            {
                return placemark.Locality;
            }
            return null;
        }

        [RelayCommand]
        private async Task LocationLblTapped() {
            await App.Current.MainPage.ShowPopupAsync(new LocationInputPopup());
        }
    }
}
