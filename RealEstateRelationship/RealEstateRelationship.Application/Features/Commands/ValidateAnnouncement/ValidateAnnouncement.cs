using MediatR;
using RealEstateRelationship.Application.Features.Commands.AddAnnouncement;

namespace RealEstateRelationship.Application.Features.Commands.ValidateAnnouncement
{
    public class ValidateAnnouncement : IRequest<AddAnnouncementCommand>
    {
        public readonly Guid Id;

        public ValidateAnnouncement(Guid id)
        {
            Id = id;
        }
    }
}
