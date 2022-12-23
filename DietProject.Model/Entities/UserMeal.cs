using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class UserMeal:BaseEntity
    {
        //
        //navigation
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }
    }
}
