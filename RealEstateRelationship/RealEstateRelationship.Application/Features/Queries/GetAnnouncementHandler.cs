using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Persistence.Repository;

namespace RealEstateRelationship.Application.Features.Queries
{
    public class GetAnnouncementHandler : IRequestHandler<GetAnnouncement, AnnouncementResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAnnouncementRepository _repository;

        public GetAnnouncementHandler(IMapper mapper, IAnnouncementRepository repository )
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<AnnouncementResponse> Handle(GetAnnouncement request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<AnnouncementResponse>(result);
        }
    }
}
