using Microsoft.AspNetCore.Mvc;
using System;

namespace CommandsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnetion()
        {
            Console.WriteLine("--> Inbound POST # Command Service");
            return Ok("Inbound test of from Platforms Controller");
        }
    }
}
