using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Choise:BaseEntity
    {
        public DateTime RelevantDate { get; set; }
        public string Meal { get; set; }
        public string Category { get; set; }
        public string FoodName { get; set; }

        public decimal Portion { get; set; }
        public decimal ExtraCalori { get; set; }    

        //navigations

        public int UserID { get; set; }
        public virtual User User { get; set; }

      
    }
}
