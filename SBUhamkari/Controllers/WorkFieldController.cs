using AutoMapper;
using DAL;
using DTO.WorkFieldDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SBUhamkari.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WorkFieldController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WorkFieldController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("GetAllWorkFields")]
        public ActionResult<WorkFieldReadDto> GetAllWorkFields()
        {
            var works = _unitOfWork.WorkFields.GetAll();
            if (works.Count() != 0)
            {
                return Ok(_mapper.Map<IEnumerable<WorkFieldReadDto>>(works));
            }
            else
            {
                return NotFound();
            }
        }

        
        [HttpPost()]
        public ActionResult WorkCreate(WorkFieldCreateDto workcreateDto)
        {
            var work = _mapper.Map<WorkField>(workcreateDto);
            _unitOfWork.WorkFields.Add(work);
            _unitOfWork.Complete();
            var workRead = _mapper.Map<WorkFieldReadDto>(work);
            return CreatedAtRoute( new { id = workRead.id }, workRead);
        }

        [HttpGet("{id}")] 
        public ActionResult<WorkFieldReadDto> GetWorkById(Guid id)
        {
            var work = _unitOfWork.WorkFields.Get(id);
    
            if (work!=null)
            {
                return Ok(_mapper.Map<WorkFieldReadDto>(work));

            }
            else
            {
                return NotFound("زمینه کاری وجود ندارد");
            }
        }

        
        [HttpPut("{id}")]
        public ActionResult UpdateWorkField(Guid id, WorkFieldCreateDto workRead)
        {
            
            var work = _unitOfWork.WorkFields.Get(id);
            if (work == null)
            {
                return NotFound();
            }

           
            work.Name = workRead.Name;
            _unitOfWork.Complete();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(Guid id)
        {
            var work = _unitOfWork.WorkFields.Get(id);
            if (work == null)
            {
                return NotFound();
            }
            _unitOfWork.WorkFields.Remove(work);
            _unitOfWork.Complete();

            return NoContent();
        }

        [HttpGet("GetUserWorkFields")]
        public ActionResult<WorkFieldReadDto> GetUserWorkFields(Guid id)
        {
            var work = _unitOfWork.PersonWorkFields.GetPersonWorkFieldsByPersonWithWorkField(id);

            if (work != null)
            {
                if (work.Count==0)
                {
                    return NotFound("زمینه کاری وجود ندارد");
                }
                return Ok(_mapper.Map<IEnumerable<WorkFieldReadDto>>(work.Select(m=> m.WorkField)));

            }
            else
            {
                return NotFound("زمینه کاری وجود ندارد");
            }
        }

        [HttpGet("GetProjectWorkFields")]
        public ActionResult<WorkFieldReadDto> GetProjectWorkFields(Guid id)
        {
            var work = _unitOfWork.ProjectWorkFields.GetProjectWorkFieldsByProjectWithWorkField(id);
            if (work != null)
            {
                return Ok(_mapper.Map<IEnumerable<WorkFieldReadDto>>(work.Select(m=> m.WorkField)));

            }
            else
            {
                return NotFound("زمینه کاری وجود ندارد");
            }
        }

        [HttpDelete("DeleteUserWorkField")]
        public ActionResult DeleteUserWorkField(Guid userId,Guid workFieldId)
        {
            var work = _unitOfWork.PersonWorkFields.GetAllPersonWorkFieldsByWorkFieldAndPerson(userId,workFieldId);
            if (work == null)
            {
                return NotFound();
            }
            _unitOfWork.PersonWorkFields.Remove(work);
            _unitOfWork.Complete();

            return NoContent();
        }

        [HttpDelete("DeleteProjectWorkField")]
        public ActionResult DeleteProjectWorkField(Guid projectId, Guid workFieldId)
        {
            var work = _unitOfWork.ProjectWorkFields.GetProjectWorkFieldsByWorkFieldAndProject(projectId, workFieldId);
            if (work == null)
            {
                return NotFound();
            }
            _unitOfWork.ProjectWorkFields.Remove(work);
            _unitOfWork.Complete();

            return NoContent();
        }

        [Authorize]
        [HttpPost("AddWorkFieldToPerson")]
        public ActionResult AddWorkFieldToPerson(Guid workId)
        {
            var personId = GetUserId();
            _unitOfWork.PersonWorkFields.Add(new PersonWorkField() { Person = _unitOfWork.People.Get(personId), WorkField = _unitOfWork.WorkFields.Get(workId) });
            _unitOfWork.Complete();
            return Ok("با موفقیت اضافه شد");
        }

        [Authorize]
        [HttpPost("AddWorkFieldToProject")]
        public ActionResult AddWorkFieldToProject(Guid projectId, Guid workId)
        {
            var userId = GetUserId();
            var project = _unitOfWork.Projects.Get(projectId);
            var projectManager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(userId, projectId);
            if (projectManager == null)
            {
                return Unauthorized("فقط مدیر پژوهش امکان ویرایش اطلاعات را دارد");
            }
            if (project == null)
            {
                return NotFound();
            }
            _unitOfWork.ProjectWorkFields.Add(new ProjectWorkField() { Project = _unitOfWork.Projects.Get(projectId), WorkField = _unitOfWork.WorkFields.Get(workId) });
            _unitOfWork.Complete();
            return Ok("با موفقیت اضافه شد");
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
