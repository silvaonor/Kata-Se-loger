using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Application.Persistence.Repository
{
    public interface IAnnouncementRepository : IAsyncRepository<Announcement>
    {
        Task<Announcement> ValidateAsync(Guid Id);
    }
}
