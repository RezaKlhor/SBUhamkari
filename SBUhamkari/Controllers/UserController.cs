using AutoMapper;
using DAL;
using DTO.UserDtos;
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
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("GetUserByUsername")]
        public ActionResult GetUserByUsername(string username)
        {
            var user = _unitOfWork.Users.GetUserByUsernameWithRole(username);
            
            if (user == null)
            {
                return NotFound("کاربر مورد نظر وجود ندارد");

            }
            return Ok(MapUserProfile(user));
           
        }

        [HttpGet("GetUserById")]
        public ActionResult GetUserById(Guid id)
        {
            var user = _unitOfWork.Users.Get(id);
            if (user == null)
            {
                return NotFound("کاربر مورد نظر وجود ندارد");

            }
             return Ok(MapUserProfile(user));
        }

        [Authorize]
        [HttpGet("AddUserToProject")]
        public ActionResult AddUserToProject(Guid userId,Guid projectId)
        {
            var currentUserId = GetUserId();
            var project = _unitOfWork.Projects.Get(projectId);
            var projectManager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(currentUserId, projectId);
            if (projectManager == null)
            {
                return Unauthorized("فقط مدیر پژوهش امکان ویرایش اطلاعات را دارد");
            }
            try
            {
                var projectParticipation = new ProjectParticapation
                {
                    Project = _unitOfWork.Projects.Get(projectId),
                    User = _unitOfWork.Users.Get(currentUserId)
                };
                _unitOfWork.ProjectParticapations.Add(projectParticipation);
                _unitOfWork.Complete();
                return Ok(".کاربر به پژوهش اضافه شد");
            }catch(Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }

        [HttpGet("GetUsersParticipates")]
        public ActionResult<UserDto> GetUsersParticipate(Guid projectId)
        {
            var users = _unitOfWork.Users.GetUsersByProject(projectId);
            if (users == null)
            {
                return NotFound("کاربر مورد نظر وجود ندارد");

            }
            var userDtos = new List<UserDto>();
            foreach (var item in users)
            {
                userDtos.Add(MapUserProfile(item));
            }
            return Ok(userDtos);
            
        }
        private Guid GetUserId()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IEnumerable<Claim> claims = identity.Claims;
            var userId = new Guid(claims.Where(m => m.Type == JwtRegisteredClaimNames.Jti).First().Value);
            return userId;
        }
        private UserDto MapUserProfile(User user)
        {
            switch (user.Role.Name)
            {
                case Constants.StudentRole:
                    var student = _mapper.Map<UserDto>(_unitOfWork.Students.Get(user.id));
                    student.Role = user.Role.Name;
                    return student;
                    break;
                case Constants.ProfessorRole:
                    var professor = _mapper.Map<UserDto>(_unitOfWork.Professors.Get(user.id));
                    professor.Role = user.Role.Name;
                    return professor;
                    break;
                case Constants.CompanyRole:
                    var compnay = _mapper.Map<UserDto>(_unitOfWork.Companies.Get(user.id));
                    compnay.Role = user.Role.Name;
                    return compnay;
                    break;
                default:
                    return null;
            }
        }


    }
}
