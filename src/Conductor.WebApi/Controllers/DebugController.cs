using Microsoft.AspNetCore.Mvc;
using Conductor.Core.Dependencies;

namespace Conductor.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DebugController : ControllerBase
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public DebugController(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetDateTime()
        {
            var dateTime = _dateTimeProvider.GetCurrentDateTime();
            return Ok(dateTime);
        }
    }
}