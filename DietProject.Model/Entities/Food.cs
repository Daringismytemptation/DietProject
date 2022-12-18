using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Food:BaseEntity
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }

        //navigation
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<FoodDetail> FoodDetails { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }

        public Food()
        {
            FoodDetails=new HashSet<FoodDetail>();
            Meals=new HashSet<Meal>();
        }


    }
}
