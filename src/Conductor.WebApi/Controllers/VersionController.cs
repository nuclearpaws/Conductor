using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Conductor.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();

            var name = assemblyName.Name;
            var version = assemblyName.Version;

            var result = new {
                Name = name,
                Version = $"{version.Major}.{version.Minor}.{version.Build}.{version.Revision}",
            };

            return Ok(result);
        }
    }
}