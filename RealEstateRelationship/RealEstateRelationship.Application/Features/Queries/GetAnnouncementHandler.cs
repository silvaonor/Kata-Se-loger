using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Persistence;

namespace RealEstateRelationship.Application.Features.Queries
{
    public class GetAnnouncementHandler : IRequestHandler<GetAnnouncement, AnnouncementQuery>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncAnnouncementRepository _repository;

        public GetAnnouncementHandler(IMapper mapper, IAsyncAnnouncementRepository repository )
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<AnnouncementQuery> Handle(GetAnnouncement request, CancellationToken cancellationToken)
        {
            // mapper in progress :'(
            var result = _repository.GetByIdAsync(request.Id);
            return //_mapper.Map<AnnouncementQuery>(result);
                Task.FromResult(new AnnouncementQuery()
                {
                    Id = result.Result.Id,
                    Description = result.Result.Description,
                    Localisation = new LocalisationQueriesVm
                    {
                        City = result.Result.Localisation.City,
                        Country = result.Result.Localisation.Country,
                        Street = result.Result.Localisation.Street,
                    },
                    Status = (int)result.Result.Status,
                    Title = result.Result.Title,
                    Type = (int)result.Result.Type,
                });
        }
    }
}
