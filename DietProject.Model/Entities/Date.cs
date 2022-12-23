using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Date:BaseEntity
    {
        public Date()
        {
            Users = new HashSet<User>();
        }
        public DateTime RelevantDate { get; set; }
        //Navigations

        public virtual ICollection<User> Users { get; set; }
    }
}
