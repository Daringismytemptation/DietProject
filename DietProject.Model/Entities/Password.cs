using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Entities
{
    public class Password:BaseEntity
    {
        
        public string UserPassword { get; set; }


        //navigation
        public int? UserID { get; set; }
        public virtual User User { get; set; }











    }
}
