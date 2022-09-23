using RealEstateRelationship.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateRelationship.Application.Persistence
{
    public class AnnouncementRepository : IAsyncAnnoucementRepository
    {
        public Task<Announcement> AddAsync(Announcement entity)
        {
            throw new NotImplementedException();
        }

        public Task<Announcement> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task ValidateAsync(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
