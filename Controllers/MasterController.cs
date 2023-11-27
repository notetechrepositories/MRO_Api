using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MRO_Api.IRepository;

namespace MRO_Api.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMasterRepository _masterRepository;
        public MasterController(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }
    }
}
