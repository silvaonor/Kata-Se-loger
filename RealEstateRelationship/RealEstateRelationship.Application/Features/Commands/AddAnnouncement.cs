using MediatR;

namespace RealEstateRelationship.Application.Features.Commands
{
    public class AddAnnouncement : IRequest<AnnouncementCommand>
    {
        private readonly AnnouncementCommand _command;

        public AddAnnouncement(AnnouncementCommand command)
        {
            _command = command;
        }
    }
}
