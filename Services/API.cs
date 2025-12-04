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
        public static async Task<WeatherRoot> GetWeatherData(double longitude, double latitude) => await HttpCommunication<WeatherRoot>.Get($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true&hourly=temperature_2m,weathercode,visibility,precipitation,apparent_temperature,precipitation_probability&start_date={DateTime.Now.ToString("yyyy-MM-dd")}&end_date={DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}");
        public static async Task<WeeklyWeatherRoot> GetWeeklyWeatherData(double longitude, double latitude) => await HttpCommunication<WeeklyWeatherRoot>.Get($"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&daily=weather_code,temperature_2m_max,temperature_2m_min,rain_sum,wind_direction_10m_dominant&start_date={DateTime.Now.ToString("yyyy-MM-dd")}&end_date={DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")}");
    }
}