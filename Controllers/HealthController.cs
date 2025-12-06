using Microsoft.AspNetCore.Mvc;

namespace VisionFlowAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        /// <summary>
        /// Returns API health status
        /// </summary>
        [HttpGet]
        public IActionResult Get() => Ok(new { status = "VisionFlow API is running!" });
    }
}
