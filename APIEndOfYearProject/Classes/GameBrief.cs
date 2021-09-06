using System;
using System.Collections.Generic;

namespace APIEndOfYearProject.Classes
{
    public class GameBrief
    {
        public int GameID { get; set; }
        public string Winner { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Villan> Villans { get; set; }


    }
}