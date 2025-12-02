using WeatherApp.Classes;

public class CurrentWeather
{
    public string time { get; set; }
    public double interval { get; set; }
    public double temperature { get; set; }
    public double windspeed { get; set; }
    public double winddirection { get; set; }
    public double is_day { get; set; }
    public int weathercode { get; set; }
    public string weatherIconUrl => is_day==1 ? WeatherIcons.Icons[weathercode].Day.image: WeatherIcons.Icons[weathercode].Night.image;
}

public class CurrentWeatherUnits
{
    public string time { get; set; }
    public string interval { get; set; }
    public string temperature { get; set; }
    public string windspeed { get; set; }
    public string winddirection { get; set; }
    public string is_day { get; set; }
    public string weathercode { get; set; }
}

public class Hourly
{
    public List<string> time { get; set; }
    public List<double> temperature_2m { get; set; }
    public List<int> weathercode { get; set; }
    public List<double> visibility { get; set; }
    public List<double> precipitation { get; set; }
    public List<double> apparent_temperature { get; set; }
    public List<double> precipitation_probability { get; set; }
}

public class HourlyUnits
{
    public string time { get; set; }
    public string temperature_2m { get; set; }
    public string weathercode { get; set; }
    public string visibility { get; set; }
    public string precipitation { get; set; }
    public string apparent_temperature { get; set; }
    public string precipitation_probability { get; set; }
}

public class WeatherRoot
{
    public double latitude { get; set; }
    public double longitude { get; set; }
    public double generationtime_ms { get; set; }
    public double utc_offset_seconds { get; set; }
    public string timezone { get; set; }
    public string timezone_abbreviation { get; set; }
    public double elevation { get; set; }
    public CurrentWeatherUnits current_weather_units { get; set; }
    public CurrentWeather current_weather { get; set; }
    public HourlyUnits hourly_units { get; set; }
    public Hourly hourly { get; set; }
}
