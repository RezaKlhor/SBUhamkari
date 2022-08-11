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

        
        
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ProjectController(IMapper mapper, IUnitOfWork unitOfWork)
        {
           
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetAllProjects")]
        public ActionResult<ProjectDto> GetAllProjects()
        {
            var projects = _unitOfWork.Projects.GetAll();
                if (projects.Count() != 0)
                {
                    return Ok(_mapper.Map<IEnumerable< ProjectDto>>(projects));
                }
                else
                {
                    return NotFound();
                }
        }
        [HttpGet("GetProjectById")]
        public ActionResult<ProjectDto> GetProject(Guid id)
        {
            var project = _unitOfWork.Projects.Get(id);
    
            if (project!=null)
            {
                return _mapper.Map<ProjectDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectByName")]
        public ActionResult<ProjectDto> GetProject(string name)
        {
            var project = _unitOfWork.Projects.GetProjectByName(name);

            if (project != null)
            {
                return _mapper.Map<ProjectDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }
    }
}