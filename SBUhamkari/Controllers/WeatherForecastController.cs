using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.Models;

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
        private readonly DatabaseContext database;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,DatabaseContext databaseContext)
        {
            database = databaseContext;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            Student student = new Student();
            student.guid = new Guid();
            student.CreateTime = DateTime.Now;
            student.Firstname = "Reza";
            student.Lastname = "Kalhori";
            student.BirthDate = DateTime.Now;
            student.gender = Gender.male;
            student.Username = "RezKalhor";
            student.Password = "65165";
            student.Faculty = new Faculty();
            
            database.Students.Add(student);
            database.SaveChanges();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}