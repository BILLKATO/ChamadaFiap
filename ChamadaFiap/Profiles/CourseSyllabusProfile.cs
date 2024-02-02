using AutoMapper;
using ChamadaFiap.Dto;
using ChamadaFiap.Entities;

namespace ChamadaFiap.Profiles
{
    public class CourseSyllabusProfile : Profile
    {
        public CourseSyllabusProfile()
        {
            CreateMap<CourseSyllabus, ReadCourseSyllabusDto>().ReverseMap();
        }
    }
}
