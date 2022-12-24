using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Choise:BaseEntity
    {

        //navigations

        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int DateID { get; set; }
        public virtual Date Date { get; set; }
    }
}
