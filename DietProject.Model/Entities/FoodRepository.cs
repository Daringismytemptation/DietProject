
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class FoodRepository
    {
        CaloriesDBContext context;
        public FoodRepository()
        {
            context = new CaloriesDBContext();
        }
        /// <summary>
        /// user id parametresine göre seçmiş oldugu foods
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>List<Food></Food></returns>
        public List<Food> GetByUserId(int userID)
        {
            var foodDetails = context.FoodDetails.Where(a => a.UserID == userID);
            var food = context.Foods.Where(a => a.FoodDetails == foodDetails);
            return food.ToList();
        }
        /// <summary>
        /// foodidye sahip foodları bul-ver update
        /// </summary>
        /// <param name="foodID"></param>
        /// <returns></returns>
        public Food GetByFoodId(int foodID)
        {
            return context.Foods.Find(foodID);
        }
        /// <summary>
        /// seçilen food'u güncelleme
        /// </summary>
        /// <param name="food"></param>
        /// <returns>true/false</returns>
        public bool Update(Food food)
        {
            Food updateFood = GetByFoodId(food.ID);
            updateFood.Name = food.Name;
            updateFood.Image = food.Image;
            return context.SaveChanges() > 0;
        }
        /// <summary>
        /// yeni food eklemek
        /// </summary>
        /// <param name="food"></param>
        /// <returns>true/false</returns>
        public bool Insert(Food food)
        {
            context.Foods.Add(food);
            return context.SaveChanges() > 0;
        }
        /// <summary>
        /// foodsu seçen useridyi silme
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public bool Delete(Food food)
        {
            var foods = context.Foods.Where(a => a.ID == food.ID);
            var foodDetails = context.FoodDetails.Where(a => a.Foods == foods);
            var user = context.Users.Where(a => a.FoodDetails == foodDetails).FirstOrDefault();
            context.Users.Remove(user);

            return context.SaveChanges() > 0;
        }
    }
}
