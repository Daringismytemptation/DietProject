using DietProject.DAL.EntityConfigurations;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL
{
    public class CalorieDBContext:DbContext
    {
        public CalorieDBContext() : base("Data Source=DESKTOP-UDDU8J5;Initial Catalog=CeliacDietProject;Integrated Security=true;")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodDetail> FoodDetails { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<ExtraCalorie> ExtraCalories { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new PasswordConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new FoodDetailConfiguration());
            modelBuilder.Configurations.Add(new ExtraCalorieConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());


        }
    }
}
