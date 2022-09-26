using MediatR;

namespace RealEstateRelationship.Application.Features.Commands
{
    public class ValidateAnnouncement : IRequest<AnnouncementCommand>
    {
        public readonly Guid Id;

        public ValidateAnnouncement(Guid id)
        {
            Id = id;
        }
    }
}
