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
    [Route("api/MyService6")]
    [ApiController]
    public class MyService6Controller : ControllerBase
    {
        private readonly ValueService _service;
        private readonly IOptionsSnapshot<MyOptions> _settings;
        //private readonly IOptions<MyOptions> _monitorOptions;

        public MyService6Controller(IOptionsSnapshot<MyOptions> settings, ValueService service)
        {
            _settings = settings;
            //_monitorOptions = optionsAccessor;
            _service = service;
        }

        [HttpGet("Test")]
        public string Get()
        {
            return $@"
                IOptions<>:         { _settings.Value.Option1 } 
                IOptionsSnapshot<>: { _service.GetValue() },
                Are same:           { _service == _settings }";
        }

        [HttpGet("GetMyValue6")]
        public IActionResult GetMyValue6()
        {
            //var myString = String.Empty;

            //for (int x = 0; x < 30; x++)
            //{
            //    myString += _snapshotOptions.Value.Option1 + " || ";

            //    Thread.Sleep(1000);
            //}

            return Ok(new { MyValue = _settings.Value.Option1 });
        }

        //[HttpGet("GetMyValue62")]
        //public IActionResult GetMyValue62()
        //{
        //    //var myString = String.Empty;

        //    //for (int x = 0; x < 30; x++)
        //    //{
        //    //    myString += _snapshotOptions.Value.Option1 + " || ";

        //    //    Thread.Sleep(1000);
        //    //}

        //    return Ok(new { MyValue = _monitorOptions.Value.Option1 });
        //}

    }
}
