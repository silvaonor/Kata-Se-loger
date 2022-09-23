using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Application.Persistence
{
    public interface IAsyncAnnoucementRepository
    {
        Task<Announcement> GetByIdAsync(Guid Id);
        Task<Announcement> AddAsync(Announcement entity);
        Task ValidateAsync(Guid Id);
    }
}
