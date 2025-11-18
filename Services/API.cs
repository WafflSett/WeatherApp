using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public static class API
    {
        public static async Task<WeatherRoot> GetWeatherData(double longitude, double latitude) => await HttpCommunication<WeatherRoot>.Get($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true&hourly=temperature_2m,weathercode,visibility,precipitation,apparent_temperature,precipitation_probability");
    }
}