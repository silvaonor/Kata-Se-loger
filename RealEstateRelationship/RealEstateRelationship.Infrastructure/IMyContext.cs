using Microsoft.EntityFrameworkCore;
using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Infrastructure
{
    public interface IMyContext
    {
        public Dictionary<Guid, Announcement> FakeDatabase { get; set; }
    }
}