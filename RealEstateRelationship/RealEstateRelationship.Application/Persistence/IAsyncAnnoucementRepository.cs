using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Application.Persistence
{
    public interface IAsyncAnnouncementRepository
    {
        Task<Announcement> GetByIdAsync(Guid Id);
        Task<Announcement> AddAsync(Announcement entity);
        Task<Announcement> ValidateAsync(Guid Id);
    }
}
