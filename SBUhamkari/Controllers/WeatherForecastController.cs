using DAL;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Models;
using System.Linq;

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

        public WeatherForecastController(ILogger<WeatherForecastController> logger,HamkariContext databaseContext)
        {
            database = databaseContext;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WorkField> Get()
        {



            //ProjectRepositoryTests projectRepositoryTests = new ProjectRepositoryTests(database);
            //projectRepositoryTests.

            using (var unitOfWork = new UnitOfWork(database))
            {
                var projects = unitOfWork.Projects.GetProjectsByManager(
                    unitOfWork.ProjectManagers.GetAll().FirstOrDefault().id);
                    
            }
            //var projects = user.projects.ToList<Project>();
            return null;
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //
        }
    }
}