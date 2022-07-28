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

            //database.Add(new EducationInstitute
            //{
            //    Name = "SBU"
            //});
            //database.Add(new Faculty
            //{
            //    Name = "CSE"
            //    ,
            //    EducationInstitute = database.EducationInstitutes.First<EducationInstitute>()

            //}) ;

            //database.Add(new Student
            //{
            //    Username = "RezaKlhor",
            //    Password = "324reza",
            //    Firstname = "Reza",
            //    Lastname = "Kalhori",
            //    gender = Gender.male,
            //    StudentID = 96243057,
            //    BirthDate = new DateTime(1999, 6, 10),

            //});

            //database.Add(new Company
            //{
            //    CompanyName = "مرکز رشد دانشکده کامپیوتر",
            //    CompanyIDnumber = 2222222222,
            //    Username = "CSEroshd",
            //    Password = "as6d4",


            //});
            //database.Add(new Professor
            //{
            //    Username = "Dr.vahidi",
            //    Password = "51324342",
            //    Firstname = "Mojtaba",
            //    Lastname = "Vahidi",
            //    gender = Gender.male,
            //    NationalIdNum = 1535132133,
            //    PersonnelID = 235133212,
            //    BirthDate = new DateTime(1980, 1, 1)
            //});

            //WorkField workField = new WorkField("AI", student);
            //database.WorkFields.Add(workField);

            var user = database.Users.Where<User>(m => m.Username == "RezaKlhor").FirstOrDefault();
            //database.ProjectManagers.Add(new ProjectManager
            //{
            //    Project = database.Projects.First(),
            //    User= user
            //}) ;
            ////user.projects.Add(new Project
            ////{
            ////    Name="jashuid",
            ////    ProjectExplain="asbdusa",
            ////    ProjectState=ProjectState.Ongoing,

            ////});
            ////

            //database.SaveChanges();
            //var projectmanagers = database.ProjectManagers.Where(m=>m.Project.Name== "Billak"&& m.User.Username=="RezaKlhor").FirstOrDefault();
            var userw2 = database.Projects.First().ProjectParticipants;
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