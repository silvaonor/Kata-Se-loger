using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateRelationship.Application.Features.Events;

namespace RealEstateRelationship.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnnouncementController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnnouncement([FromRoute] Guid Id)
        {
            var response = await _mediator.Send(new GetAnnouncement(Id));
            return Ok(response);
        }
    }
}