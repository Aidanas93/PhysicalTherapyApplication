using AutoMapper;
using PhysicalTherapyProject.Application.Models.DTO;
using PhysicalTherapyProject.Domain.Models;

namespace PhysicalTherapyProject.Application.Infrastructure
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<RegistrationDto, ApplicationUser>()
                .ForMember(d => d.UserName,
                    opt => opt.MapFrom(src => src.Email)
                );
        }
    }
}
