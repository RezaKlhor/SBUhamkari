using AutoMapper;
using DAL;
using DTO.UserDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SBUhamkari.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly string _key;

        public LoginController(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost()]
        public ActionResult Login(LoginDto loginDto)
        {
            var user = _unitOfWork.Users.GetUserByUsernameWithRole(loginDto.Username);
            if (user == null)
            {
                return NotFound("کاربر با این شناسه کاربری وجود ندارد");
            }
            if (user.Password!=loginDto.Password)
            {
                return NotFound("رمز عبور اشتباه است");
            }
            var userRole = user.Role;
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role,user.Role.Name),
                new Claim(JwtRegisteredClaimNames.Jti,user.id.ToString()),
                
            };
            var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
                );
            return Ok(new
            {
                token=new JwtSecurityTokenHandler().WriteToken(token),
                role= user.Role.Name

            });
        }

        // logout
    }
}
