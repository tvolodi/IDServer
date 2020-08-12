using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDServer.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Value 1");
            resultList.Add("Value 2");
            resultList.Add("Value 3");

            return resultList;
        }
    }
}
