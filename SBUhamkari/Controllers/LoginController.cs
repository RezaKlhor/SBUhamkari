using AutoMapper;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace SBUhamkari.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly string _key

        public LoginController(IUnitOfWork unitOfWork, IMapper mapper,string _key)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            var user = _unitOfWork.Users.GetUserByUsername(username);
            if (user == null)
            {
                return NotFound("کاربر با این شناسه کاربری وجود ندارد");
            }
            if (user.Password!=password)
            {
                return NotFound("رمز عبور اشتباه است");
            }
            var tokenHandler = new JwtSecurityTokenHandler();

        }
    }
}
