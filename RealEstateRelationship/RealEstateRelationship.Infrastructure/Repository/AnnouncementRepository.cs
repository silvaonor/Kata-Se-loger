using RealEstateRelationship.Application.Persistence;
using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Infrastructure
{
    public class AnnouncementRepository : IAsyncAnnouncementRepository
    {
        private readonly IMyContext _context;
        public AnnouncementRepository(IMyContext context)
        {
            _context = context;
        }

        public Task<Announcement> AddAsync(Announcement entity)
        {
            entity.Id = Guid.NewGuid();
            _context.FakeDatabase.Add(entity.Id, entity);
            return Task.FromResult(entity);
        }

        public Task<Announcement> GetByIdAsync(Guid Id)
        {
            if (!_context.FakeDatabase.ContainsKey(Id)) return null;
            return Task.FromResult(_context.FakeDatabase[Id]);
        }

        public Task<Announcement> ValidateAsync(Guid Id)
        {
            if (!_context.FakeDatabase.ContainsKey(Id)) return null;
            _context.FakeDatabase[Id].Status = AnnouncementStatus.Validated;
            return Task.FromResult(_context.FakeDatabase[Id]);
        }
    }
}
