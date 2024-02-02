using AutoMapper;
using ChamadaFiap.Dto;
using ChamadaFiap.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChamadaFiap.Profiles
{
    public class ClassProfile : Profile
    {
        public ClassProfile()
        {
            CreateMap<Class, ReadClassDto>().ReverseMap();
        }
    }
}
