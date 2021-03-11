using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceOptionsSample.Controllers
{
    [Route("api/IConfig")]
    [ApiController]
    public class IConfigController : ControllerBase
    {
        private readonly IConfiguration Configuration;

        public IConfigController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet("GetMyValue7")]
        public IActionResult GetMyValue4()
        {
            var myOpts = new MyOptions();
            Configuration.GetSection("MyOptions").Bind(myOpts);

            return Ok(new { MyValue = myOpts.Option1 + " | " + myOpts.Option2 });

            //return Ok(new { MyValue = _optionsDelegate.CurrentValue.Option1 });
        }
    }
}
