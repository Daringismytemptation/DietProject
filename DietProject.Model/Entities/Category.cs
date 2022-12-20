using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Foods = new HashSet<Food>();
        }

        public string Name { get; set; }

        // Navigation
        public virtual ICollection<Food> Foods { get; set; }

    }
}
