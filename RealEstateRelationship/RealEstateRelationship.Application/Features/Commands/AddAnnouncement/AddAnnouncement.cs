using MediatR;

namespace RealEstateRelationship.Application.Features.Commands.AddAnnouncement
{
    public class AddAnnouncement : IRequest<AddAnnouncementCommand>
    {
        private readonly AddAnnouncementCommand _command;

        public AddAnnouncement(AddAnnouncementCommand command)
        {
            _command = command;
        }
    }
}
