using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class ExtraCalorie:BaseMeal
    {
        public ExtraCalorie()
        {
            
        }

        public decimal Calorie { get; set; }


        // Navigation


        public int? MealID { get; set; }
        public virtual Meal Meal { get; set; }

       
    }
}
