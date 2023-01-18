using DietProject.DAL.EntityConfigurations;
using DietProject.DAL.Strategy;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL
{
    public class CaloriesDBContext:DbContext
    {
        public CaloriesDBContext() : base("Data Source=.;Initial Catalog=CeliacDietProjectFinal;Integrated Security=true;")
        {
            Database.SetInitializer(new CaloriesStrategy());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Meal> Meals { get; set; }
       
        public DbSet<Food> Foods { get; set; }
       
        public DbSet<Category> Categories { get; set; }
    
       
        public DbSet<Choise> Choises { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new PasswordConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
         
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ChoiseConffiguration());


        }
    }
}
