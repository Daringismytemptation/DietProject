using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Meal : BaseEntity
    {
        public Meal()
        {
            UserMeals = new HashSet<UserMeal>();
            Foods = new HashSet<Food>();
        }


        public string MealName { get; set; }


        // Navigations

        public virtual ICollection<UserMeal> UserMeals { get; set; }

        public virtual ICollection<Food> Foods { get; set; }

        public int? ExtraCalorieID { get; set; }
        public virtual ExtraCalorie ExtraCalorie { get; set; }

    
    }
}
