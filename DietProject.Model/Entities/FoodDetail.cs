using DietProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class FoodDetail:BaseEntity
    {
        public decimal Calorie { get; set; }

        public decimal Portion { get; set; }

        //navigations

        public virtual ICollection<Food> Foods { get; set; }

        public  int? UserID { get; set; }
        public virtual User User { get; set; }


        public FoodDetail()
        {
            Foods=new HashSet<Food>();
        }


    }
}
