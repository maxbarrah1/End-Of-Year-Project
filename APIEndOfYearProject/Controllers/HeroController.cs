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
    public class HeroController : ControllerBase
    {
        public List<Hero> testheroes = new List<Hero>(){
            new Hero (1, "Max", 1, 6, 3)
        };


        [HttpGet]
        public List<Hero> GetHeroes(){
        
            return this.testheroes;
        }

        [HttpGet]
        [Route("{id}")]
        public List<Hero> GetHero(){
            return testheroes.Where(x => x.HeroID == HeroID).First();
        }
        
        [HttpPost]
        public Hero AddHero([FromBody] Hero h)
        {
            testheroes.Add(h);
            return h;
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteHero(int id)
        {
            int count = testheroes.Where(x => x.HeroID == HeroID).Count();
            testheroes.RemoveAll( x=>x.HeroID == HeroID);
            return count + " Heroes Deleted";
        }
        
        [HttpPut]
        public int PutHero([FromBody] Hero NewHero)
        {
            int count = 0;
            int num = testheroes.Count();

            for(int i = 0; i < num; i++){
                h = NewHero;
                count++;
            }
            return count;
        }
        
    }
}
