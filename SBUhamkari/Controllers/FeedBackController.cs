using DAL;
using DTO;
using DTO.ProjectDtos;
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
    public class FeedBackController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FeedBackController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{id}", Name = "GetFeedbackById")]
        public ActionResult GetFeedbackById(Guid id)
        {
            var feedback = _unitOfWork.Feedbacks.GetFeedbackByIdWithUserAndProject(id);

            if (feedback != null)
            {
                return Ok(new FeedbackReadDto() { CreateTime = feedback.CreateTime, DeleteTime = feedback.DeleteTime, id = feedback.id, Text = feedback.Text, Score=feedback.Score,UserId= feedback.User.id});

            }
            else
            {
                return NotFound("بازخورد مورد نظر وجود ندارد");
            }
        }


        [Authorize]
        [HttpPost("CreateFeedback")]
        public ActionResult CreateFeedback(FeedbackCreateDto feedbackCreateDto)
        {
            
            var userId = GetUserId();
            var project = _unitOfWork.Projects.Get(feedbackCreateDto.ProjectId);
            if (project == null)
            {
                return NotFound("پژوهش وجود ندارد");
            }
            var feedback = new Feedback()
            {
                Score= feedbackCreateDto.Score,
                Project= project,
                Text= feedbackCreateDto.Text,
                User= _unitOfWork.Users.Get(userId)
            };
            _unitOfWork.Feedbacks.Add(feedback);
            try
            {
                _unitOfWork.Complete();

                return CreatedAtRoute("GetFeedbackById", new { id = feedback.id }, new FeedbackReadDto()
                {
                    id = feedback.id,
                    CreateTime = feedback.CreateTime,
                    DeleteTime = feedback.DeleteTime,
                    Text = feedback.Text,
                    Score=feedback.Score,
                    UserId=feedback.User.id
                });

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }


        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteFeedback(Guid id)
        {
            var feedback = _unitOfWork.Feedbacks.GetFeedbackByIdWithUserAndProject(id);
            if (feedback == null)
            {
                return NotFound();
            }


            var userId = GetUserId();
            if (feedback.User.id == userId)
            {
                return Unauthorized("صاحب بازخورد میتونه حذف کنه");
            }

            _unitOfWork.Feedbacks.Remove(feedback);
            _unitOfWork.Complete();

            return NoContent();
        }

        [HttpGet("GetProjectFeedbacks")]
        public ActionResult GetProjectFeedbacks(Guid projectId)
        {

            var feedbacks = _unitOfWork.Feedbacks.GetFeedbacksByProjectWithUser(projectId);
            if (feedbacks == null)
            {
                return NotFound("خبر ثبت نشده است");
            }
            var feeds = feedbacks.Select(m => new FeedbackReadDto()
            {
                id = m.id,
                Score = m.Score,
                CreateTime = m.CreateTime,
                DeleteTime = m.DeleteTime,
                Text = m.Text,
                UserId = m.User.id,
                ProjectId = m.Project.id
            }).ToList();
            if (feeds.Count==0)
            {
                return NotFound("بازخوردی وجود ندارد");
            }
            return Ok(feeds);
        }

        



        [HttpGet("GetUserFeedbacks")]
        public ActionResult GetUserFeedbacks(Guid userId)
        {

            var feedbacks = _unitOfWork.Feedbacks.GetFeedbacksByUserWithProject(userId);
            if (feedbacks == null)
            {
                return NotFound("خبر ثبت نشده است");
            }
            var feeds = feedbacks.Select(m => new FeedbackReadDto()
            {
                id = m.id,
                Score = m.Score,
                CreateTime = m.CreateTime,
                DeleteTime = m.DeleteTime,
                Text = m.Text,
                UserId = m.User.id,
                ProjectId = m.Project.id

            }).ToList();
            if (feeds.Count==0)
            {
                return NotFound("بازخوردی ثبت نشده است");
            }
            return Ok(feeds);
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
