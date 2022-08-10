using DAL;

using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Models;

namespace SBUhamkari.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProjectController> _logger;
        private readonly HamkariContext database;

        public ProjectController(ILogger<ProjectController> logger, HamkariContext databaseContext)
        {
            database = databaseContext;
            _logger = logger;
        }

        [HttpGet]
        public List<Project> GetAllProjects()
        {
            using(UnitOfWork unitOfWork = new UnitOfWork(database))
            {
                var projects= unitOfWork.Projects.GetAll();
                if (projects.Count() != 0)
                {
                    return (List<Project>)projects;
                }
                else
                {
                    return null;
                }
            }





        }
    }
}