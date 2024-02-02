using AutoMapper;
using ChamadaFiap.Dto;
using ChamadaFiap.Entities;

namespace ChamadaFiap.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, ReadStudentDto>().ReverseMap();
        }
    }
}
