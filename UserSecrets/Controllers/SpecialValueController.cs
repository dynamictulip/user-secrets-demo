using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserSecrets.Controllers
{    
    [Route("[controller]")]
    [ApiController]
    public class SpecialValueController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SpecialValueController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            return _configuration["SpecialValue"]?? "No config value found";
        }
    }
}
