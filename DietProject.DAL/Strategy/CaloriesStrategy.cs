using DietProject.Model.Entities;
using DietProject.Model.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Strategy
{
    public class CaloriesStrategy:CreateDatabaseIfNotExists<CaloriesDBContext>
    {
        protected override void Seed(CaloriesDBContext context)
        {
            User user = new User()
            {
                FirstName = "Admin",
                LastName = "Admin",
                CreationDate = DateTime.Now,
                Email = "admin.admin@gmail.com",
                Age = 18,
                Gender = EnumGender.Male,
                UserType = EnumUser.Admin,
                IsActive = true

            };
            user.Passwords.Add(new Password()
            {
                UserPassword = "admin",
                CreationDate = DateTime.Now
            });
            user.FoodDetails.Add(new FoodDetail()
            {
                CreationDate = DateTime.Now
            });

            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
