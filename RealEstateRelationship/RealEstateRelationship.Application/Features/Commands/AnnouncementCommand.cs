using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateRelationship.Application.Features.Commands
{
    public class AnnouncementCommand
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public LocalisationCommand Localisation { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        
    }

    public class LocalisationCommand
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
