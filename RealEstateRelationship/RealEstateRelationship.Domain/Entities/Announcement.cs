using RealEstateRelationship.Domain.Common;
using RealEstateRelationship.Domain.Entities.Enum;

namespace RealEstateRelationship.Domain.Entities
{
    public class Announcement : AgregateRoot
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Localisation Localisation { get; set; }
        public AnouncementType Type { get; set; }
        public AnnouncementStatus Status { get; set; }
    }
}
