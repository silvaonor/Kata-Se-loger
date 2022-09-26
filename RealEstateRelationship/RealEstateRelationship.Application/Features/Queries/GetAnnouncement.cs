using MediatR;

namespace RealEstateRelationship.Application.Features.Queries
{
    public class GetAnnouncement : IRequest<AnnouncementQuery>
    {
        public readonly Guid Id;

        public GetAnnouncement(Guid Id)
        {
            this.Id = Id;
        }

    }
}
