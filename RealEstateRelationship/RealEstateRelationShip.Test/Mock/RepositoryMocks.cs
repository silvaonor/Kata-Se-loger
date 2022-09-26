using Moq;
using RealEstateRelationship.Application.Persistence;
using RealEstateRelationship.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateRelationShip.Test.Mock
{
    public static class RepositoryMocks
    {
        public static readonly Guid CarParkAnnouncementGuid = Guid.Parse("37f8bf95-dbfb-490d-8e1c-12543a5c833f");
        public static readonly Guid AppartmentAnnouncementGuid = Guid.Parse("17a41fc5-6491-4990-bab4-651b949b4fbe");
        public static readonly Guid HouseAnnouncementGuid = Guid.Parse("2762220f-6679-4f50-8b1e-7258eef86d67");
        public static readonly Guid NoDetailAnnouncementGuid = Guid.Parse("3292cac6-8fae-4889-9739-ace495d676d9");
        public static readonly Guid NoLocationAnnouncementGuid = Guid.Parse("cfe666dd-cae0-4442-b743-d77cdbfd18c8");

        public static Dictionary<Guid, Announcement> FakeDatabase = new Dictionary<Guid, Announcement>()
        {
            { CarParkAnnouncementGuid , new Announcement(){Id = CarParkAnnouncementGuid,Title = "Car Park", Description = "Car Park", Localisation = new Localisation(){ City = "Paris", Country = "France" }, Status = AnnouncementStatus.WaitingForValidation, Type = AnouncementTypeEnum.CarPark } },
            { AppartmentAnnouncementGuid , new Announcement(){Id = AppartmentAnnouncementGuid,Title = "Appartment", Description = "Appartment", Localisation = new Localisation(){ City = "Lyon", Country = "France" }, Status = AnnouncementStatus.WaitingForValidation, Type = AnouncementTypeEnum.Appartment } },
            { HouseAnnouncementGuid , new Announcement(){Id = HouseAnnouncementGuid,Title = "House", Description = "House", Localisation = new Localisation(){ City = "Toulouse", Country = "France" }, Status = AnnouncementStatus.WaitingForValidation, Type = AnouncementTypeEnum.House } },
            { NoDetailAnnouncementGuid , new Announcement(){Id = CarParkAnnouncementGuid, Localisation = new Localisation(){ City = "Marseille", Country = "France" }, Status = AnnouncementStatus.WaitingForValidation, Type = AnouncementTypeEnum.Appartment } },
            { NoLocationAnnouncementGuid , new Announcement(){Id = CarParkAnnouncementGuid,Title = "No Location", Description = "No Location", Status = AnnouncementStatus.WaitingForValidation, Type = AnouncementTypeEnum.House } },
        };

        public static Mock<IAsyncAnnouncementRepository> GetAnnouncementRepository()
        {
            var mock = new Mock<IAsyncAnnouncementRepository>();
            //Violate DRY since our infrastructure is... already kind of a fancy mock
            mock.Setup(repo => repo.GetByIdAsync(It.IsAny<Guid>())).ReturnsAsync((Guid Id) => FakeDatabase.ContainsKey(Id) ? FakeDatabase[Id] : null);
            mock.Setup(repo => repo.AddAsync(It.IsAny<Announcement>())).ReturnsAsync((Announcement announcement) =>
            {
                announcement.Id = Guid.NewGuid();
                FakeDatabase.Add(announcement.Id, announcement);
                return announcement;
            });
            mock.Setup(repo => repo.ValidateAsync(It.IsAny<Guid>())).ReturnsAsync((Guid Id) =>
            {
                if (!FakeDatabase.ContainsKey(Id)) return null;
                FakeDatabase[Id].Status = AnnouncementStatus.Validated;
                return FakeDatabase[Id];
                });
            return mock;
        }


    }
}
