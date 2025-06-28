using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_web_api.single_scope_transient;
using Microsoft.AspNetCore.Mvc;

namespace core_web_api.controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FirstController : ControllerBase
    {
        private readonly IScoped scoped;
        private readonly ITransient transient;

        private readonly ISingleton singleton;

    private readonly ITransient _transient;

        private readonly IScoped _scoped;
        public FirstController(IScoped scoped,ITransient transient,IScoped _scoped,ITransient _transient,ISingleton singleton)
        {
            this.scoped = scoped;
            this.singleton = singleton;
            this.transient =transient;
            this._transient = _transient;
            this._scoped = _scoped;
        }

        [HttpGet]
        public IActionResult GetData()
        {
var result = new
        {
            TransientService = "First "+ transient.GetGuidOps(),
            ScopedService ="First "+ scoped.GetGuidOps(),
            TransientService_ = "second "+ _transient.GetGuidOps(),
            ScopedService_ ="second "+ _scoped.GetGuidOps(),
            SingletonService = singleton.GetGuidOps()
        };


           return Ok(result);
        }

        [HttpGet]
        [Route("/error")]
        public IActionResult HanldeError()
        {
           return Problem("Something Went Wrong");
        }
    }
}