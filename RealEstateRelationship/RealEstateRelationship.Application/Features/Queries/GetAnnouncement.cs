using MediatR;

namespace RealEstateRelationship.Application.Features.Queries
{
    public class GetAnnouncement : IRequest<AnnouncementResponse>
    {
        public readonly Guid Id;

        public GetAnnouncement(Guid Id)
        {
            this.Id = Id;
        }

    }
}
