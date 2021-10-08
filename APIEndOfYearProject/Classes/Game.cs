using System;
using System.Collections.Generic;

namespace APIEndOfYearProject.Classes
{
    public class Game
    {
        public int GameID { get; set; }
        public DateTime GameDateTime { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Villain> Villains { get; set; }
        public Game(int GameID)
        {
            this.GameID = GameID;
            
        }
    }
}