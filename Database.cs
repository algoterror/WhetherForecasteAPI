namespace WeatherForecastAPI.Data
{
    public static class Database                                                       //two static methods for retrieving weather forecast information from a list of WeatherForecast objects named weatherForecasts
    {
        public static List<WeatherForecast> weatherForecasts = new List<WeatherForecast>()
        {
            new WeatherForecast(){ Location="Loc1", Temperature=32, Description="Loc1....."},
            new WeatherForecast(){ Location="Loc2", Temperature=30, Description="Loc2....."},
            new WeatherForecast(){ Location="Loc3", Temperature=20, Description="Loc3....."}

        };
        
        public static List<WeatherForecast> Get()
        {
            return weatherForecasts;
        }

        public static WeatherForecast? GetByLocation(string location)                                   //GetByLocation method allows you to find a specific weather forecast by providing a location as a parameter
        {
            return weatherForecasts.Find(a=>a.Location==location);
        }

        public static bool  InsertWeather(WeatherForecast weatherForecast)
        {
            weatherForecasts.Add(weatherForecast);
            return true;
        }

        public static bool UpdateWeather(WeatherForecast weatherForecast)
        {
            WeatherForecast? forecast=  weatherForecasts.Find(a => a.Location == weatherForecast.Location);
            if(forecast!=null)
            {
               forecast.Temperature= weatherForecast.Temperature;
               forecast.Description= weatherForecast.Description;
                return true;
            }
            return false;
        }

        public static bool DeleteWeather(WeatherForecast weatherForecast)
        {
            WeatherForecast? forecast = weatherForecasts.Find(a => a.Location == weatherForecast.Location);
            if (forecast != null)
            {
                weatherForecasts.Remove(forecast);
                return true;
            }
            return false;
        }

    }
}
