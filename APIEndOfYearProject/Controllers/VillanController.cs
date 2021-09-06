using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIEndOfYearProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VillanController : ControllerBase
    {
        static List<Villan> villans = new List<Villan>(){
            new Villan (1, "Bad Guy", 5)
        };


        [HttpGet]
        public List<Villan> Get()
        {
            return this.villans;
        }


     
        
    }
}
