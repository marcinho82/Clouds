
using api.CloudGeo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


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
        public IEnumerable<Array> Post(Weather weather)
        {
            var result = calculate.Dias(weather);
            return result.ToArray();                   
           
        }       
    }
}
