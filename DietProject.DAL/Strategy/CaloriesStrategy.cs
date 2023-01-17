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

            context.Users.Add(user);
          

            List<Meal> meals = new List<Meal>();
            meals.Add(new Meal() { MealName = "Sabah" });
            meals.Add(new Meal() { MealName = "Öğlen" });
            meals.Add(new Meal() { MealName = "İkindi" });
            meals.Add(new Meal() { MealName = "Akşam" });
            context.Meals.AddRange(meals);



            List<Category> categories = new List<Category>();
            categories.Add(new Category() { Name = "Tatlılar" });
            categories.Add(new Category() { Name = "Etler" });
            categories.Add(new Category() { Name = "Tahıl ve Bakliyatlar" });
            categories.Add(new Category() { Name = "Meyveler" });
            categories.Add(new Category() { Name = "Kahvaltı" });
            categories.Add(new Category() { Name = "Atıştırmalıklar" });
            context.Categories.AddRange(categories);



            List<Food> foods = new List<Food>();
            foods.Add(new Food() { Id = 1, Name = "Sufle", CalorieAmountPer100gr = 387, CategoryID = 1 });
            foods.Add(new Food() { Id = 2, Name = "Islak Kek", CalorieAmountPer100gr = 357, CategoryID = 1 });
            foods.Add(new Food() { Id = 3, Name = "Alabalık", CalorieAmountPer100gr = 168, CategoryID = 2 });
            foods.Add(new Food() { Id = 4, Name = "Bonfile", CalorieAmountPer100gr = 400, CategoryID = 2 });
            foods.Add(new Food() { Id = 5, Name = "Nohut", CalorieAmountPer100gr = 410, CategoryID = 3 });
            foods.Add(new Food() { Id = 6, Name = "Bezelye", CalorieAmountPer100gr = 80, CategoryID = 3 });
            foods.Add(new Food() { Id = 7, Name = "Avokado", CalorieAmountPer100gr = 150, CategoryID = 4 });
            foods.Add(new Food() { Id = 8, Name = "Mango", CalorieAmountPer100gr = 60, CategoryID = 4 });
            foods.Add(new Food() { Id = 9, Name = "Yumurta", CalorieAmountPer100gr = 155, CategoryID = 5 });
            foods.Add(new Food() { Id = 10, Name = "Ekmek", CalorieAmountPer100gr = 220, CategoryID = 5 });
            foods.Add(new Food() { Id = 11, Name = "Cips", CalorieAmountPer100gr = 490, CategoryID = 6 });
            foods.Add(new Food() { Id = 12, Name = "Tuzlu Kraker", CalorieAmountPer100gr = 230, CategoryID = 6 });
            context.Foods.AddRange(foods);
            context.SaveChanges();
        }
    }
}
