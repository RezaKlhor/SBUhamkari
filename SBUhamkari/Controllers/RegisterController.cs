using AutoMapper;
using DAL;
using DTO.UserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
using System;

namespace SBUhamkari.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;

        public RegisterController(IMapper mapper, IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        [HttpPost("StudentRegister")]
        public ActionResult StudentRegister( [FromBody]StudentRegisterDto studentRegisterDto)
        {
            
            var userExist= _unitOfWork.Users.GetUserByUsername(studentRegisterDto.Username);
            if (userExist!=null)
            {
                return Conflict(new Response { Status = "UserAlreadyExist", Message = "این کاربر قبلا ثبت نام کرده است" });

            }
            try
            {
                var student = _mapper.Map<Student>(studentRegisterDto);
                student.Role = _unitOfWork.Roles.GetRole(Constants.StudentRole);
                _unitOfWork.Students.Add(student);
                _unitOfWork.Complete();
                return Ok(new Response { Status = "Success", Message = "کاربر با موفقیت ایجاد شد" });
            }
            catch(Exception ex) { return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message }); }
            
            

        }

        [HttpPost("ProfessorRegister")]
        public ActionResult ProfessorRegister([FromBody] ProfessorRegisterDto professorRegisterDto)
        {
            var userExist = _unitOfWork.Users.GetUserByUsername(professorRegisterDto.Username);
            if (userExist != null)
            {
                return Conflict(new Response { Status = "UserAlreadyExist", Message = "این کاربر قبلا ثبت نام کرده است" });

            }
            try
            {
                var Professor = _mapper.Map<Professor>(professorRegisterDto);
                Professor.Role = _unitOfWork.Roles.GetRole(Constants.ProfessorRole);
                _unitOfWork.Professors.Add(Professor);

                _unitOfWork.Complete();

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message = ex.InnerException.Message });
            }
            return Ok(new Response { Status = "Success", Message = "کاربر با موفقیت ایجاد شد" });


        }

        [HttpPost("CompanyRegister")]
        public ActionResult CompanyRegister([FromBody] CompanyRegisterDto companyRegisterDto)
        {
            var userExist = _unitOfWork.Users.GetUserByUsername(companyRegisterDto.Username);
            if (userExist != null)
            {
                return Conflict(new Response { Status = "UserAlreadyExist", Message = "این کاربر قبلا ثبت نام کرده است" });

            }
            try
            {
                var company = _mapper.Map<Company>(companyRegisterDto);
            company.Role = _unitOfWork.Roles.GetRole(Constants.ProfessorRole);
            _unitOfWork.Companies.Add(company);
           
                _unitOfWork.Complete();

            }
            catch (Exception ex)
            {
                return StatusCode(503, new Response { Status = "database error", Message =ex.InnerException.Message });
            }
            return Ok(new Response { Status = "Success", Message = "کاربر با موفقیت ایجاد شد" });


        }

    }
}
