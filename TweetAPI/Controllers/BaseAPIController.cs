using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TweetAPI.Controllers
{
    [ApiController]
    [Route("tweet/[controller]")]
    public class BaseAPIController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>(); 
    }
}