using AutoMapper;
using RealEstateRelationship.Application.Features.Queries;
using RealEstateRelationship.Domain.Entities;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace RealEstateRelationship.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Localisation, LocalisationResponse>();
            CreateMap<Announcement, AnnouncementResponse>()
                .ForMember(x => x.Localisation, opt => opt.MapFrom(x => x.Localisation));
        }
    }
}
