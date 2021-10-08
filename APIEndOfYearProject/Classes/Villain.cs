using System;
namespace APIEndOfYearProject.Classes
{
    public class Villain
    {
        public int VillainID { get; set; }
        public string VName { get; set; }
        public int HitPoints { get; set; }
        public Villain(int VilainID, string VName, int HitPoints)
        {
            this.VillainID = VillainID;
            this.VName = VName;
            this.HitPoints = HitPoints;
        }
    }
}