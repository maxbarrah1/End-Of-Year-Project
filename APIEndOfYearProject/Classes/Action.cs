using System;
namespace APIEndOfYearProject.Classes
{
    public class Action
    {
        public string ActionName { get; set; }
        public int DamageDelt { get; set; }
        public Action(string ActionName, int DamageDelt)
        {
            this.ActionName = ActionName;
            this.DamageDelt = DamageDelt;
            
        }
    }
}