
using api.CloudGeo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.CloudGeo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CloudsController : ControllerBase
    {
        public Calculate.Calculate calculate = new Calculate.Calculate();

        // POST api/<CloudsController>
        [HttpPost]
        public IEnumerable<string> Post(Weather weather)
        {
           return calculate.Dias(weather);                   
           
        }       
    }
}
