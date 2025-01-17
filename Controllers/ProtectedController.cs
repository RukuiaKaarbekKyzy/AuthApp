using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProtectedController : ControllerBase
    {
        [HttpGet("secure-data")]
        public IActionResult GetSecureData()
        {
            return Ok(new { Message = "Это защищенные данные" });
        }
    }

}
