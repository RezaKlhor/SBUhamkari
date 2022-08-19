using AutoMapper;
using DTO.WorkFieldDto;
using Models.Models;

namespace SBUhamkari.Profiles
{
    public class WorkFieldProfile : Profile
    {
        public WorkFieldProfile()
        {
            CreateMap<WorkField, WorkFieldReadDto>();
            CreateMap<WorkFieldCreateDto, WorkField>();
            CreateMap<WorkFieldReadDto, WorkField>();
        }
    }
}
