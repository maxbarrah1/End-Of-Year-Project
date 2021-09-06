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
    public class HeroController : ControllerBase
    {
        static List<Hero> heroes = new List<Hero>(){
            new Hero (1, "Max", 1, 6, 3, 10)
        };


        [HttpGet]
        public List<Hero> Get(){
        
            return this.heroes;
        }

        [HttpPost]
        public Post(){
            new Hero
        }

    }
}
