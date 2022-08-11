using AutoMapper;
using DAL;
using DTO.ProjectDtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
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
                return Ok(_mapper.Map<IEnumerable<ProjectReadDto>>(projects));
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("{id}",Name ="GetProjectsById")]
        public ActionResult<ProjectReadDto> GetProjectById(Guid id)
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

        [HttpGet("GetProjectsByName")]
        public ActionResult<ProjectReadDto> GetProjectsByName(string name)
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
        [HttpGet("GetProjectsByManager")]
        public ActionResult<ProjectReadDto> GetProjectsByManager(Guid managerId)
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

        [HttpGet("GetProjectsByWorkField")]
        public ActionResult<ProjectReadDto> GetProjectsByWorkField(Guid workFieldId)
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

        [HttpGet("GetProjectsByParticipator")]
        public ActionResult<ProjectReadDto> GetProjectsByParticipator(Guid participatorId)
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

        [HttpGet("GetProjectsByManagerRole")]
        public ActionResult<ProjectReadDto> GetProjectsByManagerType(Guid roleId)
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

        [HttpGet("GetProjectsByProjectState")]
        public ActionResult<ProjectReadDto> GetProjectsByProjectState(string projectState)
        {
            List<Project> project = null;
            if (projectState == Constants.ProjectStateOngoing) {  project = _unitOfWork.Projects.GetProjectsByProjectState(ProjectState.Ongoing); }
            else if(projectState==Constants.ProjectStateEnded) { project = _unitOfWork.Projects.GetProjectsByProjectState(ProjectState.Ended); }

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

        [HttpGet("GetProjectsByWorkFields")]
        public ActionResult<ProjectReadDto> GetProjectsByWorkFields(List<Guid> workFieldsId)
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
        //post api
        [HttpPost("ProjectCreate")]
        
        public ActionResult<ProjectReadDto> ProjectCreate(ProjectCreateDto projectCreateDto)
        {
            var project = _mapper.Map<Project>(projectCreateDto);
            _unitOfWork.Projects.Add(project);
            _unitOfWork.Complete();
            var projectReadDto = _mapper.Map<ProjectReadDto>(project);
            return CreatedAtRoute("GetProjectsById", new {id=projectReadDto.id},projectReadDto);

        }
        //end of post api

        [HttpPut("{id}")]
        public ActionResult UpdateProject(Guid id, ProjectUpdateDto projectUpdateDto)
        {
            var project = _unitOfWork.Projects.Get(id);
            if (project == null)
            {
                return NotFound();
            }
            //how can we update?
            project.Name = projectUpdateDto.Name;
            project.ProjectExplain = projectUpdateDto.ProjectExplain;
            project.ProjectState = projectUpdateDto.ProjectState;
            _unitOfWork.Complete();
            return NoContent();
        }
        
        [HttpPatch("{id}")]
        public ActionResult PartialProjectUpdate(Guid id, JsonPatchDocument<ProjectUpdateDto> patchDoc)
        {
            var project = _unitOfWork.Projects.Get(id);
            if (project == null)
            {
                return NotFound();
            }

            var projectToPatch = _mapper.Map<ProjectUpdateDto>(project);
            patchDoc.ApplyTo(projectToPatch, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

            if (!TryValidateModel(projectToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(projectToPatch, project);
            project.Name = projectToPatch.Name;
            project.ProjectExplain = projectToPatch.ProjectExplain;
            project.ProjectState = projectToPatch.ProjectState;
            _unitOfWork.Complete();

            

            return NoContent();
        }

    }
}