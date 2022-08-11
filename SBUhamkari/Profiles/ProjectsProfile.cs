using AutoMapper;
using DTO;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBUhamkari.Profiles
{
    public class ProjectsProfile : Profile
    {
        public ProjectsProfile()
        {
            //Source-> Dest
            CreateMap<Project, ProjectDto>();
            //CreateMap<List<Project>, List<ProjectDto>>();
        }
    }
}
