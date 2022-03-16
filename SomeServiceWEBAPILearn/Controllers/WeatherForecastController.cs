using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SomeService.Core;

namespace SomeService.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountController : ControllerBase
    {
        private readonly ICounter _counter;


        public CountController(ICounter counter)
        {
            _counter = counter;
        }

        [HttpGet]
        [Route("get_data")]
        public int Get()
        {
            return _counter.GetSomething();
        }
        [HttpPost]
        [Route("post_data")]
        public ActionResult Post(string Name, int Value)
        {
            _counter.DoSomething(Name, Value); 
            return Ok();
        }
    }
}
