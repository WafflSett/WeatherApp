using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Classes
{
    public class WeatherIcon
    {
        public Day Day { get; set; }
        public Night Night { get; set; }

        public WeatherIcon(Day day, Night night)
        {
            Day = day;
            Night = night;
        }
    }

    public class Day {
        public string description { get; set; }
        public string image { get; set; }

        public Day(string description, string image)
        {
            this.description = description;
            this.image = image;
        }
    }
    public class Night
    {
        public string description { get; set; }
        public string image { get; set; }

        public Night(string description, string image)
        {
            this.description = description;
            this.image = image;
        }
    }

    public static class WeatherIcons {
        public static readonly Dictionary<int, WeatherIcon> Icons
        = new Dictionary<int, WeatherIcon>
        {
            { 0,  new WeatherIcon(new Day("Sunny", "http://openweathermap.org/img/wn/01d@2x.png"), new Night("Clear", "http://openweathermap.org/img/wn/01n@2x.png")) },
            { 1,  new WeatherIcon(new Day("Mainly Sunny", "http://openweathermap.org/img/wn/01d@2x.png"), new Night("Mainly Clear", "http://openweathermap.org/img/wn/01n@2x.png")) },
            { 2,  new WeatherIcon(new Day("Partly Cloudy", "http://openweathermap.org/img/wn/02d@2x.png"), new Night("Partly Cloudy", "http://openweathermap.org/img/wn/02n@2x.png")) },
            { 3,  new WeatherIcon(new Day("Cloudy", "http://openweathermap.org/img/wn/03d@2x.png"), new Night("Cloudy", "http://openweathermap.org/img/wn/03n@2x.png")) },

            { 45, new WeatherIcon(new Day("Foggy", "http://openweathermap.org/img/wn/50d@2x.png"), new Night("Foggy", "http://openweathermap.org/img/wn/50n@2x.png")) },
            { 48, new WeatherIcon(new Day("Rime Fog", "http://openweathermap.org/img/wn/50d@2x.png"), new Night("Rime Fog", "http://openweathermap.org/img/wn/50n@2x.png")) },

            { 51, new WeatherIcon(new Day("Light Drizzle", "http://openweathermap.org/img/wn/09d@2x.png"), new Night("Light Drizzle", "http://openweathermap.org/img/wn/09n@2x.png")) },
            { 53, new WeatherIcon(new Day("Drizzle", "http://openweathermap.org/img/wn/09d@2x.png"), new Night("Drizzle", "http://openweathermap.org/img/wn/09n@2x.png")) },
            { 55, new WeatherIcon(new Day("Heavy Drizzle", "http://openweathermap.org/img/wn/09d@2x.png"), new Night("Heavy Drizzle", "http://openweathermap.org/img/wn/09n@2x.png")) },
            { 56, new WeatherIcon(new Day("Light Freezing Drizzle", "http://openweathermap.org/img/wn/09d@2x.png"), new Night("Light Freezing Drizzle", "http://openweathermap.org/img/wn/09n@2x.png")) },
            { 57, new WeatherIcon(new Day("Freezing Drizzle", "http://openweathermap.org/img/wn/09d@2x.png"), new Night("Freezing Drizzle", "http://openweathermap.org/img/wn/09n@2x.png")) },

            { 61, new WeatherIcon(new Day("Light Rain", "http://openweathermap.org/img/wn/10d@2x.png"), new Night("Light Rain", "http://openweathermap.org/img/wn/10n@2x.png")) },
            { 63, new WeatherIcon(new Day("Rain", "http://openweathermap.org/img/wn/10d@2x.png"), new Night("Rain", "http://openweathermap.org/img/wn/10n@2x.png")) },
            { 65, new WeatherIcon(new Day("Heavy Rain", "http://openweathermap.org/img/wn/10d@2x.png"), new Night("Heavy Rain", "http://openweathermap.org/img/wn/10n@2x.png")) },
            { 66, new WeatherIcon(new Day("Light Freezing Rain", "http://openweathermap.org/img/wn/10d@2x.png"), new Night("Light Freezing Rain", "http://openweathermap.org/img/wn/10n@2x.png")) },
            { 67, new WeatherIcon(new Day("Freezing Rain", "http://openweathermap.org/img/wn/10d@2x.png"), new Night("Freezing Rain", "http://openweathermap.org/img/wn/10n@2x.png")) },

            { 71, new WeatherIcon(new Day("Light Snow", "http://openweathermap.org/img/wn/13d@2x.png"), new Night("Light Snow", "http://openweathermap.org/img/wn/13n@2x.png")) },
            { 73, new WeatherIcon(new Day("Snow", "http://openweathermap.org/img/wn/13d@2x.png"), new Night("Snow", "http://openweathermap.org/img/wn/13n@2x.png")) },
            { 75, new WeatherIcon(new Day("Heavy Snow", "http://openweathermap.org/img/wn/13d@2x.png"), new Night("Heavy Snow", "http://openweathermap.org/img/wn/13n@2x.png")) },
            { 77, new WeatherIcon(new Day("Snow Grains", "http://openweathermap.org/img/wn/13d@2x.png"), new Night("Snow Grains", "http://openweathermap.org/img/wn/13n@2x.png")) },

            { 80, new WeatherIcon(new Day("Light Showers", "http://openweathermap.org/img/wn/09d@2x.png"), new Night("Light Showers", "http://openweathermap.org/img/wn/09n@2x.png")) },
            { 81, new WeatherIcon(new Day("Showers", "http://openweathermap.org/img/wn/09d@2x.png"), new Night("Showers", "http://openweathermap.org/img/wn/09n@2x.png")) },
            { 82, new WeatherIcon(new Day("Heavy Showers", "http://openweathermap.org/img/wn/09d@2x.png"), new Night("Heavy Showers", "http://openweathermap.org/img/wn/09n@2x.png")) },

            { 85, new WeatherIcon(new Day("Light Snow Showers", "http://openweathermap.org/img/wn/13d@2x.png"), new Night("Light Snow Showers", "http://openweathermap.org/img/wn/13n@2x.png")) },
            { 86, new WeatherIcon(new Day("Snow Showers", "http://openweathermap.org/img/wn/13d@2x.png"), new Night("Snow Showers", "http://openweathermap.org/img/wn/13n@2x.png")) },

            { 95, new WeatherIcon(new Day("Thunderstorm", "http://openweathermap.org/img/wn/11d@2x.png"), new Night("Thunderstorm", "http://openweathermap.org/img/wn/11n@2x.png")) },
            { 96, new WeatherIcon(new Day("Light Thunderstorms With Hail", "http://openweathermap.org/img/wn/11d@2x.png"), new Night("Light Thunderstorms With Hail", "http://openweathermap.org/img/wn/11n@2x.png")) },
            { 99, new WeatherIcon(new Day("Thunderstorm With Hail", "http://openweathermap.org/img/wn/11d@2x.png"), new Night("Thunderstorm With Hail", "http://openweathermap.org/img/wn/11n@2x.png")) }
        };
    }
}
