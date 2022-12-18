using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class FoodDetails:BaseEntity
    {
        public decimal Calorie { get; set; }

        public decimal Portion { get; set; }

    }
}
