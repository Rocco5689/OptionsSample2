using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceOptionsSample.Controllers
{
    [Route("api/MyService2")]
    [ApiController]
    public class DelegateController : ControllerBase
    {
        private readonly IOptions<MyOptionsWithDelegateConfig> _optionsDelegate;

        public DelegateController(IOptions<MyOptionsWithDelegateConfig> optionsDelegate)
        {
            _optionsDelegate = optionsDelegate;
        }

        [HttpGet("GetMyValue2")]
        public IActionResult GetMyValue2() =>
            Ok(new { MyValue = _optionsDelegate.Value });
    }
}
