using AutoMapper;
using RealEstateRelationship.Application.Features.Queries;
using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Announcement, AnnouncementQuery>();
            
        }
    }
}
