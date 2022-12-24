using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class FoodDetail:BaseMeal
    {
        public FoodDetail()
        {
            Foods = new HashSet<Food>();
        }


        public decimal Calorie { get; set; }

        public decimal Portion { get; set; }

        // Navigations

        public virtual ICollection<Food> Foods { get; set; }

    




    }
}
