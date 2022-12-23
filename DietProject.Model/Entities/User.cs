using DietProject.Model.Entities;
using DietProject.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DietProject.Model.Entities
{
    public class User:BaseEntity
    {
        public User()
        {
            Passwords = new HashSet<Password>();
            UserMeals = new HashSet<UserMeal>();
            FoodDetails = new HashSet<FoodDetail>();

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }

        public EnumUser UserType { get; set; }

        public bool IsActive { get; set; }  // Admin tarafından onaylı mı?
        public EnumGender Gender { get; set; }


        // Navigations

        public virtual ICollection<Password> Passwords { get; set; }

        public virtual ICollection<UserMeal> UserMeals { get; set; }

        public virtual ICollection<FoodDetail> FoodDetails { get; set; }

    }
}
