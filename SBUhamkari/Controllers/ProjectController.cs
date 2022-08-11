using AutoMapper;
using DAL;
using DTO.ProjectDtos;
using Microsoft.AspNetCore.Authorization;
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
        //Get Api
        [HttpGet("GetAllProjects")]
        public ActionResult<ProjectReadDto> GetAllProjects()
        {
            var projects = _unitOfWork.Projects.GetAll();
                if (projects.Count() != 0)
                {
                    return Ok(_mapper.Map<IEnumerable< ProjectReadDto>>(projects));
                }
                else
                {
                    return NotFound();
                }
        }
        [HttpGet("GetProjectById")]
        public ActionResult<ProjectReadDto> GetProject(Guid id)
        {
            var project = _unitOfWork.Projects.Get(id);
    
            if (project!=null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectByName")]
        public ActionResult<ProjectReadDto> GetProject(string name)
        {
            var project = _unitOfWork.Projects.GetProjectByName(name);

            if (project != null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }
        [HttpGet("GetProjectByManager")]
        public ActionResult<ProjectReadDto> GetProjectByManager(Guid managerId)
        {
            var project = _unitOfWork.Projects.GetProjectsByManager(managerId);

            if (project != null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectByWorkField")]
        public ActionResult<ProjectReadDto> GetProjectByWorkField(Guid workFieldId)
        {
            var project = _unitOfWork.Projects.GetProjectsByWorkField(workFieldId);

            if (project != null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectByParticipator")]
        public ActionResult<ProjectReadDto> GetProjectByParticipator(Guid participatorId)
        {
            var project = _unitOfWork.Projects.GetProjectsByParticipator(participatorId);

            if (project != null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectByManagerRole")]
        public ActionResult<ProjectReadDto> GetProjectByManagerType(Guid roleId)
        {
            var project = _unitOfWork.Projects.GetProjectsByManagerType(roleId);

            if (project != null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectByProjectState")]
        public ActionResult<ProjectReadDto> GetProjectByProjectState(string projectState)
        {
            List<Project> project = null;
            if (projectState == Constants.ProjectStateOngoing) {  project = _unitOfWork.Projects.GetProjectsByProjectState(ProjectState.Ongoing); }
            else { project = _unitOfWork.Projects.GetProjectsByProjectState(ProjectState.Ended); }

            if (project != null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectsInSavebox")]
        public ActionResult<ProjectReadDto> GetProjectInSavebox(Guid userId)
        {
            var project = _unitOfWork.Projects.GetProjectsInSavedBox(userId);

            if (project != null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectByWorkFields")]
        public ActionResult<ProjectReadDto> GetProjectByWorkFields(List<Guid> workFieldsId)
        {
            var project = _unitOfWork.Projects.GetProjectsByWorkfields(workFieldsId);

            if (project != null)
            {
                return _mapper.Map<ProjectReadDto>(project);

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        //end of get apis

        [HttpPost("ProjectCreate")]
        
        public ActionResult<ProjectReadDto> ProjectCreate(ProjectCreateDto projectCreateDto)
        {
            var project = _mapper.Map<Project>(projectCreateDto);
            _unitOfWork.Projects.Add(project);
            _unitOfWork.Complete();
            var projectReadDto = _mapper.Map<ProjectReadDto>(project);
            return  CreatedAtRoute(nameof(GetProject), new { Id = projectReadDto.id }, projectReadDto);

        }
        
    }
}