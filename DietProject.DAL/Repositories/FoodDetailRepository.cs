
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class FoodDetailRepository
    {
        CaloriesDBContext context;
        public FoodDetailRepository()
        {
            context = new CaloriesDBContext();
        }
        /// <summary>
        /// userid nin food detailsleri
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>List<FoodDetail></returns>
        public List<FoodDetail> GetByUserId(int userID)
        {
            return context.FoodDetails.Where(a => a.UserID == userID).ToList();
        }
        /// <summary>
        /// bu idye sahip olan food detaili bul getir-update
        /// </summary>
        /// <param name="foodDetailID"></param>
        /// <returns>FoodDetail</returns>
        public FoodDetail GetByFoodDetailId(int foodDetailID)
        {
            return context.FoodDetails.Find(foodDetailID);
        }

        /// <summary>
        /// food detail ekleme
        /// </summary>
        /// <param name="foodDetail"></param>
        /// <returns>true/false</returns>
        public bool Insert(FoodDetail foodDetail)
        {
            context.FoodDetails.Add(foodDetail);
            return context.SaveChanges() > 0;
        }
        /// <summary>
        /// food detail güncelleme
        /// </summary>
        /// <param name="foodDetail"></param>
        /// <returns>true false</returns>
        public bool Update(FoodDetail foodDetail)
        {
            FoodDetail updateFoodDetail = GetByFoodDetailId(foodDetail.ID);
            updateFoodDetail.Portion = foodDetail.Portion;
            updateFoodDetail.Calorie = foodDetail.Calorie;
            return context.SaveChanges() > 0;
        }

        public bool Delete(FoodDetail foodDetail)
        {
            FoodDetail deleteFoodDetail = GetByFoodDetailId(foodDetail.ID);

            var users = context.Users.Where(a => a.FoodDetails == deleteFoodDetail);
            return context.SaveChanges() > 0;
        }
    }
}
