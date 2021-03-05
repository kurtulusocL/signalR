using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRServer.BusinessUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        readonly Business _business;
        public HomeController(Business business)
        {
            _business = business;
        }

        [HttpGet("{message}")]
        public async Task<IActionResult> Index(string message)
        {
            await _business.SendMessageAsync(message);
            return Ok();
        }
    }
}
