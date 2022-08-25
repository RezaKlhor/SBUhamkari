using AutoMapper;
using DAL;
using DTO.ProjectDtos;
using DTO.TaDtos;
using DTO.UserDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

        [HttpGet("GetUserNotifs")]
        public ActionResult GetUserNotifs(Guid userId)
        {
            var notifs = _unitOfWork.Notifications.GetNotificationsByReciever(userId);
            if (notifs == null)
            {
                return NotFound("اعلانی وجود ندارد");

            }
            if (notifs.Count()==0)
            {
                return NotFound("اعلانی وجود ندارد");
            }
            return Ok(notifs.Select(m=> new NotificationDto()
            {
                SenderName= m.SenderName,
                ProjectSenderId= m.Sender.id,
                RecieverId=m.Reciever.id,
                NotifText=m.NotifText,
                NotifTittle=m.NotifTittle,
                RecieverName=m.RecieverName
            }));
        }


        [HttpGet("GetUserById")]
        public ActionResult GetUserById(Guid id)
        {
            var user = _unitOfWork.Users.GetUsersByIdWithRole(id);
            if (user == null)
            {
                return NotFound("کاربر مورد نظر وجود ندارد");

            }
            return Ok(MapUserProfile(user));
        }

        [Authorize]
        [HttpGet("SendParticipationInvitation")]
        public ActionResult SendParticipationInvitation(Guid projectId,Guid userId)
        {
            var currentUserId = GetUserId();
            var project = _unitOfWork.Projects.Get(projectId);
            if (project==null)
            {
                return NotFound("پژوهش مورد نظر موجود نمیباشد");
            }
            var projectManager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(currentUserId, projectId);
            if (projectManager == null)
            {
                return Unauthorized("فقط مدیر پژوهش امکان ویرایش اطلاعات را دارد");
            }
            _unitOfWork.Invitations.Add(new ParticipationInvitation()
            {
                InvitationState = InvitationState.Pending,
                InvitedUser = _unitOfWork.Users.Get(userId),
                ProjectManager = projectManager
            });
            try
            {
                _unitOfWork.Complete();
                return Ok("درخواست برای کاربر ارسال شد");
            }catch(Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
            
        }

        [Authorize(Roles =$"{Constants.StudentRole},{Constants.ProfessorRole}")]
        [HttpPost("AddSkillToPerson")]
        public ActionResult AddSkillToPerson(SkillCreateDto skillCreateDto)
        {
            var currentUserId = GetUserId();
            if (currentUserId!= skillCreateDto.PersonId)
            {
                return Unauthorized("شما قادر به ویرایش اطلاعات دیگران نیستید");
            }
            _unitOfWork.Skills.Add(new Skill()
            {
                Person = _unitOfWork.People.Get(skillCreateDto.PersonId),
                SkillLevel = skillCreateDto.SkillLevel,
                SkillTitle = skillCreateDto.SkillTitle,

            });
            try
            {
                _unitOfWork.Complete();
                return Ok("مهارت به کاربر اضافه شد");
            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }

        [Authorize]
        [HttpDelete("DeleteSkill")]
        public ActionResult DeleteSkill(Guid skillId)
        {


            var skill = _unitOfWork.Skills.Get(skillId);
            if (skill == null)
            {
                return NotFound("مهارت مورد نظر");
            }
            _unitOfWork.Skills.Remove(skill);
            _unitOfWork.Complete();

            return NoContent();
        }

        [HttpGet("AddUserToProject")]
        public ActionResult AddUserToProject(Guid userId, Guid projectId)
        {
            var currentUserId = GetUserId();
            var project = _unitOfWork.Projects.Get(projectId);
            var projectManager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(currentUserId, projectId);
            if (projectManager == null)
            {
                return Unauthorized("فقط مدیر پژوهش امکان ویرایش اطلاعات را دارد");
            }
            var existCeck = _unitOfWork.ProjectParticapations.GetProjectParticapationsByProjectWithUser(projectId).Where(m => m.User.id == userId).FirstOrDefault();
            if (existCeck!=null)
            {
                return BadRequest("این کاربر قبلا به پژوهش اضافه شده است");
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
            } catch (Exception ex)
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

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            var userId = GetUserId();
            if (userId != id)
            {
                return Unauthorized("صاحب اکانت میتونه حذف کنه");
            }
            var user = _unitOfWork.Users.Get(id);

            if (user == null)
            {
                return NotFound();
            }
            _unitOfWork.Users.Remove(user);
            _unitOfWork.Complete();

            return NoContent();
        }

        [Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateUser(Guid id, UserUpdateDto userUpdateDto)
        {
            var userId = GetUserId();
            if (userId != userId)
            {
                return Unauthorized("صاحب اکانت میتونه ویرایش کنه");
            }
            var user = _unitOfWork.Users.GetUsersByIdWithRole(id);

            if (user == null)
            {
                return NotFound();
            }
            user.Avatar = Encoding.ASCII.GetBytes(userUpdateDto.Avatar);
            user.Username = userUpdateDto.Username;
            user.Faculty = _unitOfWork.FacultyRecords.Get(userUpdateDto.FacultyId);
            _unitOfWork.Complete();
            switch (user.Role.Name)
            {
                case Constants.StudentRole:
                    var student = _unitOfWork.Students.Get(id);
                    student.Firstname = userUpdateDto.Firstname;
                    student.Lastname = userUpdateDto.Lastname;
                    student.gender = userUpdateDto.gender;
                    student.NationalIdNum = userUpdateDto.NationalIdNum;
                    student.StudentID = userUpdateDto.StudentID;
                    student.BirthDate = userUpdateDto.BirthDate;


                    break;
                case Constants.ProfessorRole:
                    var professor = _unitOfWork.Professors.Get(id);
                    professor.Firstname = userUpdateDto.Firstname;
                    professor.Lastname = userUpdateDto.Lastname;
                    professor.gender = userUpdateDto.gender;
                    professor.NationalIdNum = userUpdateDto.NationalIdNum;
                    professor.BirthDate = userUpdateDto.BirthDate;
                    professor.PersonnelID = UInt32.Parse(userUpdateDto.PersonnelID);



                    break;
                case Constants.CompanyRole:
                    var company = _unitOfWork.Companies.Get(id);
                    company.CompanyName = userUpdateDto.CompanyName;
                    company.CompanyIDnumber = userUpdateDto.CompanyIDnumber;
                    break;
                default:
                    return null;
            }
            

            _unitOfWork.Complete();
            return NoContent();
        }

        [HttpGet("GetAllFaculties")]
        public ActionResult GetAllFaculties()
        {
            var faculties = _unitOfWork.FacultyRecords.GetAll();
            if (faculties == null)
            {
                return NotFound("کاربر مورد نظر وجود ندارد");

            }
            
           
            return Ok(faculties);
        }

        [HttpGet("GetAllUsers")]
        public ActionResult GetAllUsers()
        {
            var users = _unitOfWork.Users.GetAllUsersWithRole();
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

        [Authorize(Roles =$"{Constants.StudentRole},{Constants.ProfessorRole}")]
        [HttpPost("CreateEducationRecord")]
        public ActionResult CreateEducationRecord(EducationRecordCreateDto educationRecordCreateDto)
        {
            var userId = GetUserId();
            _unitOfWork.EducationRecords.Add(new Models.Models.EducationRecord()
            {
                Degree = educationRecordCreateDto.Degree,
                EducationState= educationRecordCreateDto.EducationState,
               
                EducationInstitueName = educationRecordCreateDto.EducationInstituteName,
                
                Person = _unitOfWork.People.Get(userId)
            });
            try
            {
                _unitOfWork.Complete();
                return Ok("درخواست شما ثبت شد");

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }


        [HttpGet("GetUsersEducationRecords")]
        public ActionResult<UserDto> GetUsersEducationRecords(Guid userId)
        {
            var users = _unitOfWork.Users.Get(userId);
            if (users == null)
            {
                return NotFound("کاربر مورد نظر وجود ندارد");

            }
            var eduRecords = _unitOfWork.EducationRecords.GetEducationRecordsByPerson(userId);
            if (eduRecords==null)
            {
                return NotFound("ثبت نشده است");
            }
           
            return Ok(eduRecords.Select(m=> new EducationRecordReadDot()
            {
                id= m.id,
                EducationState=m.EducationState,
                EducationInstituteName=m.EducationInstitueName,
                Degree=m.Degree,
                CreateTime=m.CreateTime
            }).ToList());

        }

        [Authorize]
        [HttpDelete("DeleteEducationRecord")]
        public ActionResult DeleteEducationRecord(Guid educationRecordId)
        {
            var userId = GetUserId();
            var educationRecord = _unitOfWork.EducationRecords.GetEducationRecordByIdAndPersonId(educationRecordId, userId);

           
            if (educationRecord == null)
            {
                return NotFound("شخص مورد نظر وجود ندارد");
            }
            _unitOfWork.EducationRecords.Remove(educationRecord);
            _unitOfWork.Complete();

            return NoContent();
        }


        [Authorize]
        [HttpPost("CreateContactInfo")]
        public ActionResult CreateContactInfo(ContactInfoCreateDto contactInfoCreateDto)
        {
            var userId = GetUserId();
            _unitOfWork.ContactInfos.Add(new Models.Models.ContactInfo()
            {
               Name= contactInfoCreateDto.Name,
               EntityState=contactInfoCreateDto.EntityState,
               User= _unitOfWork.Users.Get(userId),
               ContactLink=contactInfoCreateDto.ContactLink,
               ContactNumber=contactInfoCreateDto.ContactNumber,
               
            });
            try
            {
                _unitOfWork.Complete();
                return Ok("درخواست شما ثبت شد");

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }

        
        [HttpGet("GetPublicContactInfo")]
        public ActionResult GetPublicContactInfo(Guid userId)
        {
            var contIfos = _unitOfWork.ContactInfos.GetContactInfosByUser(userId, ContactInfoState.Public);
            if (contIfos==null)
            {
                return NotFound();
            }
            return Ok(contIfos.Select(m => new ContactInfoReadDto()
            {
                ContactLink = m.ContactLink,
                ContactNumber = m.ContactNumber,
                Name = m.Name
            }).ToList());
        }

        [HttpGet("GetPrivateContactInfo")]
        public ActionResult GetPrivateContactInfo(Guid userId)
        {
            var contIfos = _unitOfWork.ContactInfos.GetContactInfosByUser(userId, ContactInfoState.Private);
            if (contIfos == null)
            {
                return NotFound();
            }
            return Ok(contIfos.Select(m => new ContactInfoReadDto()
            {
                ContactLink = m.ContactLink,
                ContactNumber = m.ContactNumber,
                Name = m.Name
            }).ToList());
        }

        [HttpGet("GetUserStatistics")]
        public ActionResult GetUserStatistics(Guid userId)
        {
            var projects = _unitOfWork.Projects.GetProjectsByParticipator(userId)?? new List<Project>();
            UserStatisticsDto userStatistics = new UserStatisticsDto()
            {
                TotalFollowers = _unitOfWork.UserFollowerFollowings.GetFollowingsByFollowedID(userId)?.Count().ToString(),
                TotalFollowings = _unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(userId)?.Count().ToString(),



                TotalProjects = projects.Count().ToString()
            };
            

            return Ok(userStatistics);
        }

        [HttpGet("GetUserFollowers")]
        public ActionResult GetUserFollowers(Guid userId)
        {
            var followers = _unitOfWork.UserFollowerFollowings.GetFollowingsByFollowedID(userId).Select(m=> m.Follower).ToList();
            if (followers==null)
            {
                return NotFound();
            }
            return Ok(followers.Select(m=> MapUserProfile(_unitOfWork.Users.GetUsersByIdWithRole(m.id))).ToList());
        }

        [HttpGet("GetUserFollowings")]
        public ActionResult GetUserFollowings(Guid userId)
        {
            var followings = _unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(userId).Select(m => _unitOfWork.Users.GetUsersByIdWithRole(m.FollowedID)).ToList();
            if (followings == null)
            {
                return NotFound();
            }
            return Ok(followings.Select(m => MapUserProfile(m)).ToList());
        }

        [Authorize]
        [HttpGet("Follow")]
        public ActionResult Follow(Guid userId)
        {
            var followerId = GetUserId();
            if (_unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(followerId).Any(m=> m.FollowedID==userId))
            {
                return BadRequest("این کاربر قبلا فالو شده است");
            }
            _unitOfWork.UserFollowerFollowings.Add(new Following()
            {
                FollowedID = userId,
                Follower = _unitOfWork.Users.Get(followerId)
            });
            try
            {
                _unitOfWork.Complete();
                return Ok("درخواست شما ثبت شد");

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }

        [Authorize]
        [HttpGet("IsFollowed")]
        public ActionResult IsFollowed(Guid userId)
        {
            var followerId = GetUserId();
            if (_unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(followerId).Any(m => m.FollowedID == userId))
            {
                return Ok(true);
            }
            return Ok(false);
        }
        [Authorize]
        [HttpGet("GetMyWorldNews")]
        public ActionResult GetMyWorldNews()
        {
            //var projects = new List<Project>();
            var news = new List<ProjectNews>();
            var userId = GetUserId();
            var follows = _unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(userId).Select(m => _unitOfWork.Users.Get(m.id)).ToList();
            foreach (var item in follows)
            {
                var projects = _unitOfWork.ProjectParticapations.GetProjectParticapationsByUserWithProject(userId).Select(m => m.Project).ToList();
                if (projects == null)
                {
                    continue;
                }
                foreach (var item2 in projects)
                {
                    news.AddRange(_unitOfWork.ProjectNews.GetProjectNewsByProject(item2.id));
                }
            }
            //var news = projects.Select(m => _unitOfWork.ProjectNews.GetProjectNewsByProject(m.id)).ToList();
            //var annons = projects.Select(m=> _unitOfWork.CoAnnouncements.GetCoAnnouncementsByProject(m.id)).ToList();
            news = news.DistinctBy(m => m.id).ToList();
            return Ok(news.Select(m => new CoAnnouncementReadDto()
            {
                CreateTime = m.CreateTime,
                DeleteTime = m.DeleteTime,
                id = m.id,
                Text = m.Text,
                Tittle = m.Tittle
            }));

        }


        [Authorize]
        [HttpGet("GetMyWorldAnnounce")]
        public ActionResult GetMyWorldAnnounce()
        {
            //var projects = new List<Project>();
            var anns = new List<CoAnnouncement>();
            var userId = GetUserId();
            var follows = _unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(userId).Select(m => _unitOfWork.Users.Get(m.id)).ToList();
            foreach (var item in follows)
            {
                var projects = _unitOfWork.ProjectParticapations.GetProjectParticapationsByUserWithProject(userId).Select(m => m.Project).ToList();
                if (projects == null)
                {
                    continue;
                }
                foreach (var item2 in projects)
                {
                    anns.AddRange(_unitOfWork.CoAnnouncements.GetCoAnnouncementsByProject(item2.id));
                }
            }
            //var news = projects.Select(m => _unitOfWork.ProjectNews.GetProjectNewsByProject(m.id)).ToList();
            //var annons = projects.Select(m=> _unitOfWork.CoAnnouncements.GetCoAnnouncementsByProject(m.id)).ToList();
            anns = anns.DistinctBy(m => m.id).ToList();
            return Ok(anns.Select(m => new CoAnnouncementReadDto()
            {
                CreateTime = m.CreateTime,
                DeleteTime = m.DeleteTime,
                id = m.id,
                Text = m.Text,
                Tittle = m.Tittle
            }));

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
                    student.Faculty = user.Faculty == null ? "" : user.Faculty.Name;
                    student.Role = user.Role.Name;
                    return student;
                    break;
                case Constants.ProfessorRole:
                    var professor = _mapper.Map<UserDto>(_unitOfWork.Professors.Get(user.id));
                    professor.Faculty = user.Faculty==null?"":user.Faculty.Name;
                    professor.Role = user.Role.Name;
                    return professor;
                    break;
                case Constants.CompanyRole:
                    var compnay = _mapper.Map<UserDto>(_unitOfWork.Companies.Get(user.id));
                    compnay.Faculty = user.Faculty == null ? "" : user.Faculty.Name; 
                    compnay.Role = user.Role.Name;
                    return compnay;
                    break;
                default:
                    return null;
            }
        }


    }
}
