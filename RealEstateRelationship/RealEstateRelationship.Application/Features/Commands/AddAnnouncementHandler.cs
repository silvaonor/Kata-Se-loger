using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateRelationship.Application.Features.Commands
{
    public class AddAnnouncementHandler : IRequestHandler<AddAnnouncement, AnnouncementCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncAnnouncementRepository _repository;

        public AddAnnouncementHandler(IMapper mapper, IAsyncAnnouncementRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<AnnouncementCommand> Handle(AddAnnouncement request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
