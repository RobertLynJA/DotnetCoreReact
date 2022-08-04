using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseAPIController : ControllerBase
    {
        protected readonly IMediator Mediator;

        public BaseAPIController()
        {
            Mediator = HttpContext.RequestServices.GetService<IMediator>()!;
        }
    }
}
