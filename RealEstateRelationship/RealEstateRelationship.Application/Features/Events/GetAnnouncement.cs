using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateRelationship.Application.Features.Events
{
    public class GetAnnouncement : IRequest<AnnouncementVm>
    {
        private readonly Guid _id;

        public GetAnnouncement(Guid Id)
        {
            _id = Id;
        }

    }
}
