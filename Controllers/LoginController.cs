using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MRO_Api.IRepository;

namespace MRO_Api.Controllers
{
    [Route("api/Mro")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
    }
}
