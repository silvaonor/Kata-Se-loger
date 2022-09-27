using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Persistence.Repository;
using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Application.Features.Commands
{
    public class ValidateAnnouncementHandler : IRequestHandler<ValidateAnnouncement, AnnouncementCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAnnouncementRepository _repository;

        public ValidateAnnouncementHandler(IMapper mapper, IAnnouncementRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<AnnouncementCommand> Handle(ValidateAnnouncement request, CancellationToken cancellationToken)
        {
            var result = await _repository.ValidateAsync(request.Id);
            return _mapper.Map<Announcement, AnnouncementCommand>(result);
        }
    }
}
