using DietProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class ExtraFood
    {
        public decimal Calorie { get; set; }

        //navigation

        public virtual ICollection<User> Users { get; set; }

        public ExtraFood()
        {
            Users= new HashSet<User>();
        }

       
    }
}
