using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO.ProjectDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using DAL;

namespace SBUhamkari.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public NewsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Authorize]
        [HttpPost("CreateNews")]
        public ActionResult CreateNews(NewsCreateDto newsCreateDto)
        {
            var project = _unitOfWork.Projects.Get(newsCreateDto.ProjectId);
            if (project == null)
            {
                return NotFound("پژوهش مورد نظر وجود ندارد");
            }
            var userId = GetUserId();
            var projectMnager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(userId, newsCreateDto.ProjectId);
            if (projectMnager == null)
            {
                return Unauthorized("فقط مدیر پژوهش قادر به ایجاد خبر می‌باشد");
            }
            _unitOfWork.ProjectNews.Add(new ProjectNews()
            {
               Project= project,
               Text= newsCreateDto.Text,
               Tittle= newsCreateDto.Tittle
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

        [HttpGet("GetAllNews")]
        public ActionResult GetAllNews()
        {

            var news = _unitOfWork.ProjectNews.GetAll();
            if (news == null)
            {

                return NotFound("خبر ثبت نشده است");
            }
            if (news.Count()==0)
            {
                return NotFound("خبر ثبت نشده است");
            }
            return Ok(news);
        }

        [HttpGet("GetProjectNews")]
        public ActionResult GetProjectNews(Guid projectId)
        {

            var news = _unitOfWork.ProjectNews.GetProjectNewsByProject(projectId);
            if (news == null)
            {
                return NotFound("خبر ثبت نشده است");
            }

            return Ok(news);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteNews(Guid id)
        {
            var news = _unitOfWork.ProjectNews.GetProjectNewsWithProject(id);
            if (news == null)
            {
                return NotFound();
            }
            
            
            var userId = GetUserId();
            var projManager = _unitOfWork.ProjectManagers.GetProjectManagerByUserAndProject(userId, news.Project.id);
            if (projManager==null)
            {
                return Unauthorized("صاحب درخواست میتونه حذف کنه");
            }

            if (news == null)
            {
                return NotFound();
            }
            _unitOfWork.ProjectNews.Remove(news);
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
