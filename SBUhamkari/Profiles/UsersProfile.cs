using AutoMapper;
using DTO.ProjectDtos;
using DTO.UserDtos;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBUhamkari.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            //Source-> Dest
            CreateMap<StudentRegisterDto, Student>();
            CreateMap<ProfessorRegisterDto, Professor>();
            CreateMap<CompanyRegisterDto, Company>();
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<Person, UserDto>();
            CreateMap<Student, UserDto>();
            CreateMap<Professor, UserDto>();
            
        }
    }
}
