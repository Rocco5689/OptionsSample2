using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceOptionsSample.Controllers
{
    [Route("api/MyService3")]
    [ApiController]
    public class SubSectionController : ControllerBase
    {
        private readonly IOptions<MySubOptions> _optionsSubSection;

        public SubSectionController(IOptions<MySubOptions> optionsAccessor)
        {
            _optionsSubSection = optionsAccessor;
        }

        [HttpGet("GetMyValue3")]
        public IActionResult GetMyValue3() =>
            Ok(new { MyValue = _optionsSubSection.Value });
    }
}
