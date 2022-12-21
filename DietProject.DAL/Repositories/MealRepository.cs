
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class MealRepository
    {
        CaloriesDBContext context;
        public MealRepository()
        {
            context = new CaloriesDBContext();
            
        }
        /// <summary>
        /// useridnin seçtiği meal
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>List<Meal></returns>
        public List<Meal> GetByUserId(int userID)
        {
            var users = context.Users.Where(a => a.ID == userID);
            var meals = context.Meals.Where(a => a.Users == users);
            return meals.ToList();
        }
        /// <summary>
        /// bu idye sahip olan mealı bul bana ver-update
        /// </summary>
        /// <param name="mealID"></param>
        /// <returns>Meal</returns>
        public Meal GetByMealId(int mealID)
        {
            return context.Meals.Find(mealID);
        }
        /// <summary>
        /// meal eklemek
        /// </summary>
        /// <param name="meal"></param>
        /// <returns>true/false</returns>
        public bool Insert(Meal meal)
        {
            context.Meals.Add(meal);
            return context.SaveChanges() > 0;
        }
        /// <summary>
        /// Meal update
        /// </summary>
        /// <param name="meal"></param>
        /// <returns>true/false</returns>
        public bool Update(Meal meal)
        {
            Meal updateMeal = GetByMealId(meal.ID);
            updateMeal.MealName = meal.MealName;
            return context.SaveChanges() > 0;
        }
        public bool Delete(Meal meal)
        {
            Meal deletedMeal = GetByMealId(meal.ID);
            var users = context.Users.Where(a => a.Meals == deletedMeal).FirstOrDefault();
            context.Users.Remove(users);

            return context.SaveChanges() > 0;
        }
    }
}
