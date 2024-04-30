using Microsoft.AspNetCore.Mvc;
using WeatherForecastAPI.Data;                         //.data
namespace WeatherForecastAPI.Controllers
{
    [ApiController]                       //attribute //this class is a api controller 
    [Route("[controller]")]                                                //This attribute specifies a route template for the controller
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]                               //creating methods(get,put,post,Delete)
      
        public IEnumerable<WeatherForecast> Get()                            //This method returns an enumerable collection of WeatherForecast objects.
        {
            return Database.Get();
        }
        [HttpGet("{location}")]
       
        public WeatherForecast? Get(string location)
        {
            return Database.GetByLocation(location);
        }

        [HttpPost]
        public bool Post(WeatherForecast weatherForecast)
        {
            return Database.InsertWeather(weatherForecast);
        }

        [HttpPut]
        public bool Put(WeatherForecast weatherForecast)
        {
            return Database.UpdateWeather(weatherForecast);
        }

        [HttpDelete]
        public bool Delete(WeatherForecast weatherForecast)
        {
            return Database.DeleteWeather(weatherForecast);
        }



    }
}