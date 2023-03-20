using AutoMapper;
using MediatR;
using RealEstateRelationship.Application.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateRelationship.Application.Features.Commands.AddAnnouncement
{
    public class AddAnnouncementHandler : IRequestHandler<AddAnnouncement, AddAnnouncementCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAnnouncementRepository _repository;

        public AddAnnouncementHandler(IMapper mapper, IAnnouncementRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public Task<AddAnnouncementCommand> Handle(AddAnnouncement request, CancellationToken cancellationToken)
        {
            throw new Exception();
        }
    }
}
