﻿using AutoMapper;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO.TaDtos;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace SBUhamkari.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetTaReqById")]
        public ActionResult GetTaReqById(Guid id)
        {
            var taReq = _unitOfWork.TArequests.GetWithProfessor(id);

            if (taReq != null)
            {
                return Ok(new TaRequestReadDto() { CreateTime = taReq.CreateTime, DeleteTime = taReq.DeleteTime, id = taReq.id, Text = taReq.Text, Tittle = taReq.Tittle,ProfessorId=taReq.Professor.id });

            }
            else
            {
                return NotFound("خبر مورد نظر وجود ندارد");
            }
        }

        [Authorize(Roles ="Professor")]
        [HttpPost("CreateTaRequest")]
        public ActionResult CreateTaRequest([FromBody]TaRequestCreateDto taRequestCreateDto)
        {
            var userId = GetUserId();
            var taReq = new Models.Models.TArequest()
            {
                Tittle = taRequestCreateDto.Tittle,
                Text = taRequestCreateDto.Text,
                Professor = _unitOfWork.Professors.Get(userId)
            };
            _unitOfWork.TArequests.Add(taReq);
            try
            {
                _unitOfWork.Complete();
                return CreatedAtRoute("GetTaReqById", new { id = taReq.id }, new TaRequestReadDto() { CreateTime = taReq.CreateTime, DeleteTime = taReq.DeleteTime, id = taReq.id, Text = taReq.Text, Tittle = taReq.Tittle, ProfessorId = taReq.Professor.id });

            }catch(Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }

        
        [HttpGet("GetAllTaRequests")]
        public ActionResult GetAllTaRequests()
        {
            var temp = _unitOfWork.TArequests.GetAllWithProfessor();
            var tareqs =temp.Select(x => new TaRequestReadDto
            {
                ProfessorId = x.Professor.id,
                Text = x.Text,
                Tittle = x.Tittle,
                id=x.id,
                CreateTime=x.CreateTime,
                DeleteTime=x.DeleteTime
                


            }).ToList();
            if (tareqs==null)
            {
                return NotFound();
            }
            //maybe has bug
            return Ok(tareqs);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult DeleteTaRequest(Guid id)
        {
            var request = _unitOfWork.TArequests.GetWithProfessor(id);
            if (request == null)
            {
                return NotFound();
            }
            var userId = GetUserId();
            if (userId != request.Professor.id)
            {
                return Unauthorized("صاحب درخواست میتونه حذف کنه");
            }
            
            if (request == null)
            {
                return NotFound();
            }
            _unitOfWork.TArequests.Remove(request);
            _unitOfWork.Complete();

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateTaRequest(Guid id, TaRequestUpdateDto updateDto)
        {

            var req = _unitOfWork.TArequests.Get(id);
            if (req == null)
            {
                return NotFound();
            }

            //how can we update?
            req.Text = updateDto.Text;
            req.Tittle = updateDto.Tittle;

            _unitOfWork.Complete();
            return NoContent();
        }


        [Authorize(Roles = Constants.StudentRole)]
        [HttpPost("CreateTaApplication")]
        public ActionResult CreateTaApp([FromBody]TaAppCreateDto taAppCreateDto)
        {
            var userId = GetUserId();
            _unitOfWork.TAapplications.Add(new Models.Models.TAapplication()
            {
                Student = _unitOfWork.Students.Get(userId),
                Resume = taAppCreateDto.Resume,
                text = taAppCreateDto.text,
                Tarequest = _unitOfWork.TArequests.Get(taAppCreateDto.TarequestId)
            });
            try
            {
                _unitOfWork.Complete();
                return Created("",null);

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
        }

        [HttpGet("GetTaAppsForRequest")]
        public ActionResult GetTaAppsForRequest(Guid requestId)
        {
            var taApps = _unitOfWork.TAapplications.GetTAapplicationsByTArequestWithStudent(requestId);
            if (taApps==null)
            {
                return NotFound("درخواستی ثبت نشده است");
            }
            return Ok(taApps.Select(m=> new TaAppReadDto()
            {
                StudentId=m.Student.id,
                Resume=m.Resume,
                TarequestId=requestId,
                text=m.text,
                id= m.id,
                CreateTime=m.CreateTime
                
            }).ToList());
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
