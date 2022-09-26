using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateRelationship.Application.Features.Commands;
using RealEstateRelationship.Application.Features.Queries;

namespace RealEstateRelationship.WebAPI.Controllers
{
    [ApiController]
    [Route("annonce")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnnouncementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAnnouncement([FromRoute] Guid id)
        {
            var response = await _mediator.Send(new GetAnnouncement(id));
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddAnnouncement([FromBody] AnnouncementCommand command)
        {
            var response = await _mediator.Send(new AddAnnouncement(command));
            return Ok(response);
        }

        [HttpPost]
        [Route("validate/{id}")]
        public async Task<IActionResult> ValidateAnnouncement([FromBody] Guid id)
        {
            var response = await _mediator.Send(new ValidateAnnouncement(id));
            return Ok(response);
        }


    }
}