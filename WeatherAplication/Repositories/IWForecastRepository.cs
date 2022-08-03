using WeatherAplication.OpenWeatherMap_Model;

namespace WeatherAplication.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
