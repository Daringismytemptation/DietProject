using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Meal : BaseMeal
    {
        public Meal()
        {
            
            Foods = new HashSet<Food>();
            
        }


        public string MealName { get; set; }


        // Navigations



        public virtual ICollection<Food> Foods { get; set; }

        
       

    
    }
}
