using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIEndOfYearProject.Classes;

namespace APIEndOfYearProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VillainController : ControllerBase
    {
        public List<Villain> villains = new List<Villain>(){
            new Villain (1, "Bad Guy", 5)
        };


        [HttpGet]
        public List<Villain> Get()
        {
            return this.villains;
        }


        

        
    }
}
