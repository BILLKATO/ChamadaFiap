using AutoMapper;
using ChamadaFiap.Dto;
using ChamadaFiap.Entities;

namespace ChamadaFiap.Profiles
{
    public class ClassPeriodProfile : Profile
    {
        public ClassPeriodProfile()
        {
            CreateMap<ClassPeriod, ReadClassPeriodDto>().ReverseMap();
        }
    }
}
