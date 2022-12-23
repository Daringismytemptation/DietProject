using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Password:BaseEntity
    {
        public string UserPassword { get; set; }


        // Navigations
        public int? UserID { get; set; }
        public virtual User User { get; set; }

        

    }
}
