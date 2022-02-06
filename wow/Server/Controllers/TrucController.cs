using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace wow.Server.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class TrucController : Controller
    {
        [HttpGet("machin")]
        public int machin()
        {
            return 45;
        }
    }
}
