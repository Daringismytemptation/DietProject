using DietProject.Model.Entities;
using DietProject.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DietProject.Entities
{
    public class User:BaseEntity
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public GenderEnum Gender { get; set; }

        public int Deneme { get; set; }

        public int Deneme2 { get; set; }






    }
}
