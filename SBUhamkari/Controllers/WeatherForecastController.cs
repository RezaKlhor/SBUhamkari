using DAL;

using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Models;
using ServiceStack.Host;

namespace SBUhamkari.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly HamkariContext database;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, HamkariContext databaseContext)
        {
            database = databaseContext;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public User Get(string username)
        {
            UnitOfWork unitOfWork = new UnitOfWork(database);
            var user = unitOfWork.Users.GetUserByUsername(username);
            if (user == null)
            {
                throw new HttpException("sdas");
            }
            return user;





        }
    }
}