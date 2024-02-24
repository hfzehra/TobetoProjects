using Application.Features.Brands.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IMediator _mediator;

        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost] 
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand) 
        { 
            CreatedBrandResponse response = await _mediator.Send(createBrandCommand); 
            return Ok(response);
        }
    }
}
