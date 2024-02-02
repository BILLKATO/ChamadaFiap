using AutoMapper;
using ChamadaFiap.Dto;
using ChamadaFiap.Entities;

namespace ChamadaFiap.Profiles
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            CreateMap<Subject, ReadSubjectDto>().ReverseMap();
        }
    }
}
