using AutoMapper;
using DAL;
using DTO;
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

        
        private readonly HamkariContext _database;
        private readonly IMapper _mapper;

        public ProjectController(HamkariContext databaseContext,IMapper mapper)
        {
            _database = databaseContext;
            _mapper = mapper;
            
        }

        [HttpGet("GetAllProjects")]
        public ActionResult<ProjectDto> GetAllProjects()
        {
            using(UnitOfWork unitOfWork = new UnitOfWork(_database))
            {
                var projects= unitOfWork.Projects.GetAll();
                
                if (projects.Count() != 0)
                {
                    return Ok(_mapper.Map<ProjectDto>(projects));
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}