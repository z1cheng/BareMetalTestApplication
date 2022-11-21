using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BareMetalTestApplication.Controllers
{
    [ApiController]
    public class PingController : Controller
    {

        [HttpGet(template:"/api/ping")]
        public IActionResult Ping()
        {
            return Ok("Pong");
        }
    }
}
