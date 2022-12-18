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

        public int Age { get; set; }   

        public EnumUser UserType { get; set; }

        public bool IsActive { get; set; }  // admin tarafından onaylı mı ?
        public GenderEnum Gender { get; set; }

        //navigation
        public virtual ICollection<Password> Passwords { get; set; }

        public virtual ICollection<Meal> Meals { get; set; }

        public virtual ICollection<FoodDetail> FoodDetails { get; set; }

        public virtual ICollection<ExtraFood> ExtraFoods { get; set; }

        public User()
        {
            Passwords= new HashSet<Password>();
            Meals= new HashSet<Meal>();
            FoodDetails= new HashSet<FoodDetail>();
            ExtraFoods= new HashSet<ExtraFood>();

        }










    }
}
