using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Services
{
    public class FoodService
    {
        FoodRepository foodRepository;
        public FoodService()
        {
            foodRepository = new FoodRepository();
        }
        public List<Food> GetById(int userID)
        {
            List<Food> foods = new List<Food>();
            if (userID > 0)
            {
                foods = foodRepository.GetByUserId(userID);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değildir.");
            }
            return foods;
        }
        void CheckFoodId(int noteID)
        {
            if (noteID <= 0)
            {
                throw new Exception("Parametre değeri uygun değil");
            }
        }
        public Food GetFoodById(int foodID)
        {
            Food food = new Food();
            CheckFoodId(foodID);
            food = foodRepository.GetByFoodId(foodID);
            return food;
        }
        void SelectedFood(Food food)
        {
            if (string.IsNullOrEmpty(food.Name))
            {
                throw new Exception("Food seçmediniz");
            }
        }
        public bool Insert(Food food)
        {
            SelectedFood(food);
            food.CreationDate = DateTime.Now;
            return foodRepository.Insert(food);
        }
        public bool Update(Food food)
        {
            SelectedFood(food);
            CheckFoodId(food.ID);
            return foodRepository.Update(food);
        }
        public bool Delete(int foodID)
        {
            CheckFoodId(foodID);
            Food food = GetFoodById((int)foodID);
            return foodRepository.Delete(food);
        }
        public bool Delete(Food food)
        {
            CheckFoodId(food.ID);
            return foodRepository.Delete(food);
        }
    }
}
