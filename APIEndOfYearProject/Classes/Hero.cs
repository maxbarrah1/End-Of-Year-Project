using System;
namespace APIEndOfYearProject.Classes
{
    public class Hero
    {
        public int HeroID { get; set; }
        public string HName { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Uses { get; set; }

        public Hero(int HeroID, string HName, int MinValue, int MaxValue, int Uses)
        {
            this.HeroID = HeroID;
            this.HName = HName;
            this.MinValue = MinValue;
            this.MaxValue = MaxValue;
            this.Uses = Uses;
        }
    }
}