using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Food:BaseMeal
    {
        public Food()
        {
           
            Meals = new HashSet<Meal>();
        }

        public string Name { get; set; }
        public byte[] Image { get; set; }

        public decimal CalorieAmountPer100gr { get; set; }

        // Navigations

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

        

        public virtual ICollection<Meal> Meals { get; set; }

    }
}
