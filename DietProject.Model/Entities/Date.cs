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
            
            Choises = new HashSet<Choise>();
        }
        public DateTime RelevantDate { get; set; }


        //Navigations

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Choise> Choises { get; set; }
    }
}
