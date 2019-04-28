using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NumberValidAPI.Controllers
{
    [Route("api/number")]
    [ApiController]
    public class NumberController : ControllerBase
    {
        [Route("validate")]
        public ActionResult<string> GetNumInfo([FromQuery] string number)
        {
            return "s";
        }
        
    }
}