using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class ExtraCalorie
    {
        public decimal Calorie { get; set; }

        //navigation
        public virtual ICollection<Meal> Meals { get; set; }

        public ExtraCalorie()
        {
            Meals = new HashSet<Meal>();
        }

       
    }
}
