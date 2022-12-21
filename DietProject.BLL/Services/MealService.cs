using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Services
{
    public class MealService
    {
        MealRepository mealRepository;
        public MealService()
        {
            mealRepository = new MealRepository();
        }

        /// <summary>
        /// useridye göre mealleri getiriyor.meal Repository yardımıyla
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>List<Meal></Meal></returns>
        /// <exception cref="Exception"></exception>
        public List<Meal> GetById(int userID)
        {
            List<Meal> meals = new List<Meal>();
            if (userID > 0)
            {
                meals = mealRepository.GetByUserId(userID);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
            return meals;
        }
        /// <summary>
        /// id kontrolü
        /// </summary>
        /// <param name="noteID"></param>
        /// <exception cref="Exception"></exception>
        void CheckMealId(int noteID)
        {
            if (noteID <= 0)
            {
                throw new Exception("Parametre değeri uygun değildir");
            }
        }
        /// <summary>
        /// mealidye göre getir
        /// </summary>
        /// <param name="mealID"></param>
        /// <returns>Meal</returns>
        public Meal GetMealById(int mealID)
        {
            Meal meal = new Meal();
            CheckMealId(mealID);
            meal = mealRepository.GetByMealId(mealID);
            return meal;
        }
        /// <summary>
        /// Meal seçili olma durumu
        /// </summary>
        /// <param name="meal"></param>
        /// <exception cref="Exception"></exception>
        void SelectedMeal(Meal meal)
        {
            if (string.IsNullOrEmpty(meal.MealName))
            {
                throw new Exception("Meal bilgisi eksik");
            }
        }
        /// <summary>
        /// Meal add
        /// </summary>
        /// <param name="meal"></param>
        /// <returns>true/false</returns>
        public bool Insert(Meal meal)
        {
            SelectedMeal(meal);
            meal.CreationDate = DateTime.Now;
            return mealRepository.Insert(meal);
        }
        /// <summary>
        /// delete-mealIDye göre
        /// </summary>
        /// <param name="mealID"></param>
        /// <returns>true/false</returns>
        public bool Delete(int mealID)
        {
            CheckMealId(mealID);
            Meal meal = GetMealById(mealID);
            return mealRepository.Delete(meal);
        }
        /// <summary>
        /// delete-Meal meale göre
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public bool Delete(Meal meal)
        {
            CheckMealId(meal.ID);
            return mealRepository.Delete(meal);
        }
    }
}
