using AutoMapper;
using DAL;
using DTO.ProjectDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

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

        [HttpGet("GetAllRoles")]
        public ActionResult<Role> GetAllRoles()
        {
            var roles = _unitOfWork.Roles.GetAll();
            if (roles.Count() != 0)
            {
                return Ok(roles);
            }
            else
            {
                return NotFound();
            }
        }

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
        [HttpGet("{id}",Name ="GetProjectsById")] // this should be get project
        public ActionResult<ProjectReadDto> GetProjectById(Guid id)
        {
            var project = _unitOfWork.Projects.Get(id);
    
            if (project!=null)
            {
                return Ok(_mapper.Map<ProjectReadDto>(project));

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectByName")]
        public ActionResult<ProjectReadDto> GetProjectByName(string name)
        {
            var project = _unitOfWork.Projects.GetProjectByName(name);

            if (project != null)
            {
                return Ok(_mapper.Map<ProjectReadDto>(project));

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpPost("GetProjectsByFilter")]
        public ActionResult<ProjectReadDto> GetProjectsByFilter([FromBody]ProjectFilterDto projectFilterDto)
        {
            
            var projects = _unitOfWork.Projects.GetProjectsByAll(projectFilterDto.WorkFieldsId,projectFilterDto.ManagerRole,projectFilterDto.ProjectState);

            if (projectFilterDto.NeedState==NeedState.NEED)
            {
                projects.Where(m => _unitOfWork.CoAnnouncements.GetCoAnnouncementsByProject(m.id) != null).ToList();
            }
            if (projects != null)
            {
                return Ok(
                    projects.Select(m=> new ProjectReadDto()
                    {
                        ProjectState= m.ProjectState,
                        Name=m.Name,
                        ProjectExplain=m.ProjectExplain,
                        id=m.id,
                        CreateTime=m.CreateTime
                    })
                    );

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }
        [HttpGet("GetProjectsByManager")]
        public ActionResult<ProjectReadDto> GetProjectsByManager(Guid managerId)
        {
            var projects = _unitOfWork.Projects.GetProjectsByManager(managerId);

            if (projects != null)
            {
                return Ok(_mapper.Map<IEnumerable<ProjectReadDto>>(projects));
            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectsByWorkField")]
        public ActionResult<ProjectReadDto> GetProjectsByWorkField(Guid workFieldId)
        {
            var projects = _unitOfWork.Projects.GetProjectsByWorkField(workFieldId);

            if (projects != null)
            {
                return Ok(_mapper.Map<IEnumerable<ProjectReadDto>>(projects));

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectsByParticipator")]
        public ActionResult<ProjectReadDto> GetProjectsByParticipator(Guid participatorId)
        {
            var projects = _unitOfWork.Projects.GetProjectsByParticipator(participatorId);

            if (projects != null)
            {
                return Ok(_mapper.Map<IEnumerable<ProjectReadDto>>(projects));

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectsByManagerRole")]
        public ActionResult<ProjectReadDto> GetProjectsByManagerType(string role)
        {
            var projects = _unitOfWork.Projects.GetProjectsByManagerType(_unitOfWork.Roles.GetAll().Where(m=> m.Name==role).FirstOrDefault().id);

            if (projects != null)
            {
                return Ok(_mapper.Map<IEnumerable<ProjectReadDto>>(projects));

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [HttpGet("GetProjectsByProjectState")]
        public ActionResult<ProjectReadDto> GetProjectsByProjectState(string projectState)
        {
            List<Project> projects = null;
            if (projectState == Constants.ProjectStateOngoing) {  projects = _unitOfWork.Projects.GetProjectsByProjectState(ProjectState.Ongoing); }
            else if(projectState==Constants.ProjectStateEnded) { projects = _unitOfWork.Projects.GetProjectsByProjectState(ProjectState.Ended); }

            if (projects != null)
            {
                return Ok(_mapper.Map<IEnumerable<ProjectReadDto>>(projects));

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        [Authorize]
        [HttpGet("GetProjectsInSavebox")]
        public ActionResult<ProjectReadDto> GetProjectInSavebox()
        {

            var userId = GetUserId();
            var projects = _unitOfWork.Projects.GetProjectsInSavedBox(userId);
            if (projects != null)
            {
               return Ok(_mapper.Map<IEnumerable<ProjectReadDto>>(projects));
            }
            else
            {
               return NotFound(Constants.ProjectNotFoundMessage);
            }


           
           
        }

        [Authorize]
        [HttpPost("PutProjectInSavebox")]
        public ActionResult<ProjectReadDto> PutProjectInSavebox(Guid projectId)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;

            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;
                var userId = new Guid(claims.Where(m => m.Type == JwtRegisteredClaimNames.Jti).First().Value);
                try
                {
                    _unitOfWork.SavedProjects.Add(new SavedProject { Project = _unitOfWork.Projects.Get(projectId), User = _unitOfWork.Users.Get(userId) });
                    _unitOfWork.Complete();
                    return Ok("پروژه ذخیره شد");
                }catch(Exception ex) {
                    return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message }); 
                }
                   
                


            }
            else
            {
                return Unauthorized("ابتدا وارد حساب کاربری خود شوید");
            }


        }

        [HttpPost("GetProjectsByWorkFields")]
        public ActionResult<ProjectReadDto> GetProjectsByWorkFields(List<Guid> workFieldsId)
        {
            var project = _unitOfWork.Projects.GetProjectsByWorkfields(workFieldsId);

            if (project != null)
            {
                return Ok(project.Select(m=> 
                new ProjectReadDto()
                {
                    ProjectState=m.ProjectState,
                    Name=m.Name,
                    ProjectExplain= m.ProjectExplain
                }).ToList());

            }
            else
            {
                return NotFound(Constants.ProjectNotFoundMessage);
            }
        }

        //end of get apis
        //post api
        [Authorize]
        [HttpPost("ProjectCreate")]
        public ActionResult<ProjectReadDto> ProjectCreate(ProjectCreateDto projectCreateDto)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claims = identity.Claims;
            var userId = new Guid(claims.Where(m => m.Type == JwtRegisteredClaimNames.Jti).First().Value);
            var project = _mapper.Map<Project>(projectCreateDto);
            _unitOfWork.Projects.Add(project);
            _unitOfWork.ProjectManagers.Add(new ProjectManager { Project = project, User = _unitOfWork.Users.Get(userId) });
            _unitOfWork.ProjectParticapations.Add(new ProjectParticapation() { Project=project,User=_unitOfWork.Users.Get(userId) });
            _unitOfWork.Complete();
            var projectReadDto = _mapper.Map<ProjectReadDto>(project);
            return CreatedAtRoute("GetProjectsById", new {id=projectReadDto.id},projectReadDto);
        }
        //end of post api

        [Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateProject(Guid id, ProjectUpdateDto projectUpdateDto)
        {
            var userId = GetUserId();
            var projectManager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(userId, id);
            if (projectManager==null)
            {
                return Unauthorized("فقط مدیر پژوهش امکان ویرایش اطلاعات را دارد");
            }
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

        [Authorize]
        [HttpPatch("{id}")]
        public ActionResult PartialProjectUpdate(Guid id, JsonPatchDocument<ProjectUpdateDto> patchDoc)
        {
            var userId = GetUserId();
            var project = _unitOfWork.Projects.Get(id);
            var projectManager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(userId, id);
            if (projectManager==null)
            {
                return Unauthorized("فقط مدیر پژوهش امکان ویرایش اطلاعات را دارد");
            }
            if (project == null)
            {
                return NotFound();
            }

            var projectToPatch = _mapper.Map<ProjectUpdateDto>(project);
            patchDoc.ApplyTo(projectToPatch, ModelState);

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

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(Guid id)
        {
            var userId = GetUserId();
            var project = _unitOfWork.Projects.Get(id);
            var projectManager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(userId, id);
            if (projectManager == null)
            {
                return Unauthorized("فقط مدیر پژوهش امکان ویرایش اطلاعات را دارد");
            }
            if (project == null)
            {
                return NotFound();
            }
            _unitOfWork.Projects.Remove(project);
            _unitOfWork.Complete();

            return NoContent();
        }

        private Guid GetUserId()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claims = identity.Claims;
            var userId = new Guid(claims.Where(m => m.Type == JwtRegisteredClaimNames.Jti).First().Value);
            return userId;
        }


    }
}