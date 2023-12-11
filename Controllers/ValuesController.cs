using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MRO_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost("new")]
        public async Task<IActionResult> ValidatePin()
        {
         
            return Ok(1);
        }
    }
}
