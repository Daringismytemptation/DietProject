using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class ExtraCalorie:BaseEntity
    {
        public ExtraCalorie()
        {
            Meals = new HashSet<Meal>();
        }

        public decimal Calorie { get; set; }


        // Navigation

        public virtual ICollection<Meal> Meals { get; set; }

       
    }
}
