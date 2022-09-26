using AutoMapper;
using Moq;
using RealEstateRelationship.Application.Features.Queries;
using RealEstateRelationship.Application.Persistence;
using RealEstateRelationship.Application.Profiles;
using RealEstateRelationship.Domain.Entities;
using RealEstateRelationShip.Test.Mock;
using Shouldly;
using Xunit;

namespace RealEstateRelationShip.Test.Features
{
    public class AnnouncementFeature
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncAnnouncementRepository> _MockAnnouncementRepository;
        public AnnouncementFeature()
        {
            _MockAnnouncementRepository = RepositoryMocks.GetAnnouncementRepository();
            var configurationProvider = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task OnGetAnnouncementWhenUserIsPassingAnExistingIdShouldSuceed()
        {
            var handler = new GetAnnouncementHandler(_mapper, _MockAnnouncementRepository.Object);
            var result = await handler.Handle(new GetAnnouncement(RepositoryMocks.HouseAnnouncementGuid), CancellationToken.None);
            result.ShouldBeOfType<AnnouncementQuery>();
            result.ShouldBeSameAs(new AnnouncementQuery() { Id = RepositoryMocks.HouseAnnouncementGuid, Title = "House", Description = "House", Localisation = new LocalisationQueriesVm() { City = "Toulouse", Country = "France" }, Status = 0, Type = 1 });
        }

    }
}
