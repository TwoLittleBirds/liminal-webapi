using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace liminal_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VersionController : ControllerBase
    {
        private readonly ILogger<VersionController> _logger;

        public VersionController(ILogger<VersionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return GetType().Assembly.GetName().Version.ToString();
        }
    }
}
