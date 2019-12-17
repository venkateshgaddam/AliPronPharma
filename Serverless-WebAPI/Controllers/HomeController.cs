using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Serverless_WebAPI.Controllers
{
    [Route("aws/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("Get")]
        public string TestApi()
        {
            return "Api Testing is Done";
        }
    }
}