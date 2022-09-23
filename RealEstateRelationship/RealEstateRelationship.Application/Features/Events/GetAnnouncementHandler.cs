using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateRelationship.Application.Features.Events
{
    public class GetAnnouncementHandler : IRequestHandler<GetAnnouncement, AnnouncementVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncAnnoucementRepository _repository;

        public GetAnnouncementHandler(IMapper mapper, IAsyncAnnoucementRepository repository )
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<AnnouncementVm> Handle(GetAnnouncement request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
