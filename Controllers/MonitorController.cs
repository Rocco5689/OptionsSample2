using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceOptionsSample.Controllers
{
    [Route("api/MyService5")]
    [ApiController]
    public class MonitorController : ControllerBase
    {
        private static IOptionsMonitor<MyOptions> meOptions;

        private readonly IOptionsMonitor<MyOptions> _optionsDelegate;

        public MonitorController(IOptionsMonitor<MyOptions> optionsDelegate)
        {
            _optionsDelegate = optionsDelegate;
        }

        [HttpGet("GetMyValue5")]
        public IActionResult GetMyValue5()
        {
            //var myString = String.Empty;

            //for(int x = 0; x < 30; x++)
            //{
            //    myString += _optionsDelegate.CurrentValue.Option1 + " || ";

            //    Thread.Sleep(1000);
            //}

            return Ok(new { MyValue = _optionsDelegate.CurrentValue.Option1 } );
        }
    }
}
