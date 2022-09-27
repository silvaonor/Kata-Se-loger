using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Persistence.Repository;

namespace RealEstateRelationship.Application.Features.Queries
{
    public class GetAnnouncementHandler : IRequestHandler<GetAnnouncement, AnnouncementQuery>
    {
        private readonly IMapper _mapper;
        private readonly IAnnouncementRepository _repository;

        public GetAnnouncementHandler(IMapper mapper, IAnnouncementRepository repository )
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<AnnouncementQuery> Handle(GetAnnouncement request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<AnnouncementQuery>(result);
                //Task.FromResult(new AnnouncementQuery()
                //{
                //    Id = result.Result.Id,
                //    Description = result.Result.Description,
                //    Localisation = new LocalisationQueriesVm
                //    {
                //        City = result.Result.Localisation.City,
                //        Country = result.Result.Localisation.Country,
                //        Street = result.Result.Localisation.Street,
                //    },
                //    Status = (int)result.Result.Status,
                //    Title = result.Result.Title,
                //    Type = (int)result.Result.Type,
                //});
        }
    }
}
