using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public partial class WeeklyWeatherViewModel : ObservableObject
    {
        [ObservableProperty]
        public WeeklyWeatherRoot? weatherData = Task.Run(async()=>await API.GetWeeklyWeatherData(App.Location.Longitude, App.Location.Latitude)).Result;

        [ObservableProperty]
        ObservableCollection<Tuple<string, string, float, float, float, int>> weeklyData;

        partial void OnWeatherDataChanged(WeeklyWeatherRoot? value)
        {
            for (int i = 0; i < WeatherData.daily.temperature_2m_max.Length; i++)
            {
                Daily day = WeatherData.daily;
                WeeklyData.Add(Tuple.Create(day.time[i], day.weather_code[i].ToString(), day.temperature_2m_min[i], day.temperature_2m_max[i], day.rain_sum[i], day.wind_direction_10m_dominant[i]));
            }
        }
    }
}
