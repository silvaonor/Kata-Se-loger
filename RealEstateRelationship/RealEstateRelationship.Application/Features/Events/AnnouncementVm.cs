using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateRelationship.Application.Features.Events
{
    public class AnnouncementVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //public Localisation Localisation { get; set; }
        //public AnouncementTypeEnum Type { get; set; }

    }
}
