using RealEstateRelationship.Application.Persistence.Repository;
using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Infrastructure
{
    public class AnnouncementRepository : IAnnouncementRepository
    {
        private readonly IMyContext _context;
        public AnnouncementRepository(IMyContext context)
        {
            _context = context;
        }

        public async Task<Announcement> AddAsync(Announcement entity)
        {
            entity.Id = Guid.NewGuid();
            _context.FakeDatabase.Add(entity.Id, entity);
            return await Task.FromResult(entity).ConfigureAwait(false);
        }

        public async Task<Announcement> GetByIdAsync(Guid Id)
        {
            return await (!_context.FakeDatabase.ContainsKey(Id) ? null : Task.FromResult(_context.FakeDatabase[Id])).ConfigureAwait(false);
        }

        public async Task<Announcement> ValidateAsync(Guid Id)
        {
            if (!_context.FakeDatabase.ContainsKey(Id)) return null;
            _context.FakeDatabase[Id].Status = AnnouncementStatus.Validated;
            return await Task.FromResult(_context.FakeDatabase[Id]).ConfigureAwait(false);
        }
    }
}
