using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Features.Commands.AddAnnouncement;
using RealEstateRelationship.Application.Persistence.Repository;
using RealEstateRelationship.Domain.Entities;

namespace RealEstateRelationship.Application.Features.Commands.ValidateAnnouncement
{
    public class ValidateAnnouncementHandler : IRequestHandler<ValidateAnnouncement, AddAnnouncementCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAnnouncementRepository _repository;

        public ValidateAnnouncementHandler(IMapper mapper, IAnnouncementRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<AddAnnouncementCommand> Handle(ValidateAnnouncement request, CancellationToken cancellationToken)
        {
            var result = await _repository.ValidateAsync(request.Id);
            return _mapper.Map<Announcement, AddAnnouncementCommand>(result);
        }
    }
}
