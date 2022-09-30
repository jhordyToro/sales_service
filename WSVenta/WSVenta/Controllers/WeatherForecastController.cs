using Microsoft.AspNetCore.Mvc;

namespace WSVenta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> lts = new List<WeatherForecast>();
            lts.Add(new WeatherForecast() { Id = 123456, Name = "Jhordy" });
            return lts;
        }
    }
}