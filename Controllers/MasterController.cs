using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MRO_Api.IRepository;
using MRO_Api.Model;
using System.Text.Json.Nodes;

namespace MRO_Api.Controllers
{
    [Route("api/common")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMasterRepository _masterRepository;
        public MasterController(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }


        [HttpPost("get")]
        public  async Task<IActionResult>commonGet([FromBody]CommonModel data)
        {
            var result = await _masterRepository.commonGet(data);
            return Ok(result);
        }


    }
}
