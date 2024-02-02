using AutoMapper;
using ChamadaFiap.Dto;
using ChamadaFiap.Entities;

namespace ChamadaFiap.Profiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, ReadTeamDto>().ReverseMap();
        }
    }
}
