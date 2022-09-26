using Microsoft.EntityFrameworkCore;
using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Infrastructure
{
    public class MyContext : DbContext, IMyContext
    {
        public Dictionary<Guid, Announcement> FakeDatabase { get; set; }
    }
}
