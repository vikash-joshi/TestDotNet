using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace WebAPITest.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult Check()
        {
            return Ok("HELLO");
        }

    }
}