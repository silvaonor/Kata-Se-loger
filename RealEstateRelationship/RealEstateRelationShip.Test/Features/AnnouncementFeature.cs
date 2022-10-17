using AutoMapper;
using Moq;
using RealEstateRelationship.Application.Features.Queries;
using RealEstateRelationship.Application.Persistence.Repository;
using RealEstateRelationship.Application.Profiles;
using RealEstateRelationShip.Test.Mock;
using Shouldly;
using Xunit;

namespace RealEstateRelationShip.Test.Features
{
    [TestClass]
    public class AnnouncementFeature
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAnnouncementRepository> _MockAnnouncementRepository;
        public AnnouncementFeature()
        {
            _MockAnnouncementRepository = RepositoryMocks.GetAnnouncementRepository();
            var configurationProvider = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = configurationProvider.CreateMapper();
        }

        [TestMethod]
        public async Task OnGetAnnouncementWhenUserIsPassingAnExistingIdShouldSuceed()
        {
            var handler = new GetAnnouncementHandler(_mapper, _MockAnnouncementRepository.Object);
            var result = await handler.Handle(new GetAnnouncement(RepositoryMocks.HouseAnnouncementGuid), CancellationToken.None);
            List<int> test = new List<int>() {3, 4,1, 2, -1};

            result.ShouldBe(new AnnouncementQuery() { Id = RepositoryMocks.HouseAnnouncementGuid, Title = "House", Description = "House"});
            //result.ShouldBe(new AnnouncementQuery() { Id = RepositoryMocks.HouseAnnouncementGuid, Title = "House", Description = "House", Localisation = new LocalisationQueriesVm() { City = "Toulouse", Country = "France" }, Status = 0, Type = 1 });

        }

    }
}
