using Microsoft.AspNetCore.Http;
using AutoMapper;
using DAL;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
namespace SBUhamkari.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApplyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("{id}", Name = "GetAnnounceById")]
        public ActionResult GetAnnounceById(Guid id)
        {
            var ann = _unitOfWork.CoAnnouncements.Get(id);

            if (ann != null)
            {
                return Ok(new AnnouncementReadDto() { CreateTime = ann.CreateTime, DeleteTime = ann.DeleteTime, id = ann.id, Text = ann.Text, Tittle = ann.Tittle });

            }
            else
            {
                return NotFound("آگهی مورد نظر وجود ندارد");
            }
        }

        [Authorize]
        [HttpPost("CreateCoAnnouncement")]
        public ActionResult CreateCoAnnouncement(AnnouncementCreateDto announcementCreateDto)
        {
            var project = _unitOfWork.Projects.Get(announcementCreateDto.projectId);
            if (project==null)
            {
                return NotFound("پژوهش مورد نظر وجود ندارد");
            }
            var userId = GetUserId();
            var projectMnager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(userId, announcementCreateDto.projectId);
            if (projectMnager==null)
            {
                return Unauthorized("فقط مدیر پژوهش قادر به ایجاد آگهی می‌باشد");
            }
            var ann = new CoAnnouncement()
            {
                Creator = projectMnager,
                State = State.Open,
                Text = announcementCreateDto.Text,
                Tittle = announcementCreateDto.Tittle,
            };
            _unitOfWork.CoAnnouncements.Add(ann);
            try
            {
                _unitOfWork.Complete();
                return CreatedAtRoute("GetAnnounceById", new { id = ann.id }, new AnnouncementReadDto()
                {
                    id = ann.id,
                    CreateTime = ann.CreateTime,
                    DeleteTime = ann.DeleteTime,
                    Text = ann.Text,
                    Tittle = ann.Tittle
                });

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public ActionResult UpdateAnnouncemnet(Guid id, AnnouncementUpdateDto announcementUpdateDto)
        {
            var userId = GetUserId();
            var announc = _unitOfWork.CoAnnouncements.GetCoAnnouncementByIdWithProjManager(id);
            if (announc==null)
            {
                return NotFound();
            }
            if (!_unitOfWork.ProjectManagers.GetProjectManagersByManagerWithProject(userId).Contains(announc.Creator))
            {
                return Unauthorized("فقط مدیر پژوهش امکان ویرایش آگهی را دارد");
            }



            //how can we update?
            announc.Tittle = announcementUpdateDto.Tittle;
            announc.Text = announcementUpdateDto.Text;



            _unitOfWork.Complete();
            return NoContent();
        }


        [HttpGet("GetAnnouncementsForProjectWithApplications")]
        public ActionResult GetAnnouncementsForProjectWithApplications(Guid projectId)
        {
            
            var coAnnounce = _unitOfWork.CoAnnouncements.GetProjectsCoAnnouncement(projectId);
            
            if (coAnnounce == null)
            {
                return NotFound("آگهی ثبت نشده است");
            }
            var annoncs = coAnnounce.Select(m => new AnnouncementReadDto()
            {
                CreateTime = m.CreateTime,
                DeleteTime = m.DeleteTime,
                id = m.id,
                Text = m.Text,
                Tittle = m.Tittle,
                Applications = _unitOfWork.CoApplications.GetCoApplicationsByAnnouncementWithApplicant(m.id).Select(m => new ApplicationReadDto()
                {
                    CV = m.CV,
                    Text = m.Text,
                    UserId = m.Applicant.id
                }).ToList()
            }); 
            if (annoncs.Count() ==0)
            {
                return NotFound("آگهی ای یافت نشد");
            }
            return Ok(annoncs);
        }

        [HttpGet("GetAllAnnouncements")]
        public ActionResult GetAllAnnouncements()
        {

            var coAnnounce = _unitOfWork.CoAnnouncements.GetAll();
            if (coAnnounce == null)
            {
                return NotFound("آگهی ثبت نشده است");
            }
            var anncs = coAnnounce.Select(m => new AnnouncementReadDto()
            {
                CreateTime = m.CreateTime,
                DeleteTime = m.DeleteTime,
                id = m.id,
                Text = m.Text,
                Tittle = m.Tittle,
                Applications = _unitOfWork.CoApplications.GetCoApplicationsByAnnouncementWithApplicant(m.id).Select(m => new ApplicationReadDto()
                {
                    CV = m.CV,
                    Text = m.Text,
                    UserId = m.Applicant.id
                }).ToList()
            }).ToList();
            if (anncs.Count==0)
            {
                return NotFound();
            }
            return Ok(anncs);
        }
        

        [Authorize]
        [HttpPost("Apply")]
        public ActionResult Apply(ApplyDto applyDto)
        {
            
            var userId = GetUserId();
           
            _unitOfWork.CoApplications.Add(new CoApplication()
            {
               Applicant = _unitOfWork.People.Get(userId),
               CoAnnouncement = _unitOfWork.CoAnnouncements.Get( applyDto.CoAnnouncementId),
               CV=applyDto.CV,
               Text=applyDto.Text,
              
               
            });
            try
            {
                _unitOfWork.Complete();
                return Created("درخواست شما ثبت شد", null);

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }

        [Authorize]
        [HttpGet("AcceptUser")]
        public ActionResult AcceptUser(Guid projectId,Guid applicantId)
        {

            var userId = GetUserId();
            var projectMnager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(userId,projectId);
            if (projectMnager == null)
            {
                return Unauthorized("فقط مدیر پژوهش قادر به تایید می‌باشد");
            }
            var projectPar = new ProjectParticapation()
            {
                Project = _unitOfWork.Projects.Get(projectId),
                User = _unitOfWork.Users.Get(applicantId)


            };
            _unitOfWork.ProjectParticapations.Add(projectPar);
            try
            {
                _unitOfWork.Complete();
                _unitOfWork.Notifications.Add(new Notification()
                {
                    Sender = projectPar.Project,
                    SenderName = projectPar.Project.Name,
                    Reciever = projectPar.User,
                    RecieverName = projectPar.User.Username,
                    NotifText = $"شما به پروژه{projectPar.Project.Name}اضافه شدید",
                    NotifTittle = "شما قبول شدید و به پژوهش اضافه شدید"
                });
                _unitOfWork.Complete();
                return Created("درخواست شما ثبت شد", null);

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
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
