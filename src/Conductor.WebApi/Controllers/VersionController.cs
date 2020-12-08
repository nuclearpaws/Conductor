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
            var assemblyName = Assembly.GetExecutingAssembly()?.GetName();

            var name = assemblyName.Name;
            var version = $"{assemblyName.Version.Major}.{assemblyName.Version.MajorRevision}.{assemblyName.Version.Minor}.{assemblyName.Version.MinorRevision} ({assemblyName.Version.Build})";

            var result = new
            {
                name,
                version,
            };

            return Ok(result);
        }
    }
}
