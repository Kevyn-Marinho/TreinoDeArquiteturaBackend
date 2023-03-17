using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopKMS.Users.Services.CreateUser;

namespace ShopKMS.Users.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("")]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

    }
}
