using AutoMapper;
using PhysicalTherapyProject.Domain.Models;
using PhysicalTherapyProjectV2.Models;
using PhysicalTherapyProjectV2.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhysicalTherapyProjectV2.Infrastructure
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
