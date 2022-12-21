using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Services
{
    public class FoodDetailService
    {
        FoodDetailRepository foodDetailRepository;
        public FoodDetailService()
        {
            foodDetailRepository = new FoodDetailRepository();
        }
        public List<FoodDetail> GetById(int userID)
        {
            List<FoodDetail> foodDetails = new List<FoodDetail>();
            if (userID > 0)
            {
                foodDetails = foodDetailRepository.GetByUserId(userID);
            }
            else
            {
                throw new Exception("parametre değeri uygun değildir.");
            }
            return foodDetails;
        }
        void CheckFoodDetailId(int foodDetailID)
        {
            if (foodDetailID <= 0) throw new Exception("Parametre değeri uygun değildir");
        }
        public FoodDetail GetFoodDetailById(int foodDetailID)
        {
            FoodDetail foodDetail = new FoodDetail();
            CheckFoodDetailId(foodDetailID);
            foodDetail = foodDetailRepository.GetByFoodDetailId(foodDetailID);
            return foodDetail;
        }
        void SelectedFoodDetail(FoodDetail foodDetail)
        {
            if (string.IsNullOrEmpty(foodDetail.Portion.ToString())) throw new Exception("Eksik bilgi seçtiniz.");
        }
        public bool Insert(FoodDetail foodDetail)
        {
            SelectedFoodDetail(foodDetail);
            foodDetail.CreationDate = DateTime.Now;
            return foodDetailRepository.Insert(foodDetail);
        }
        public bool Update(FoodDetail foodDetail)
        {
            SelectedFoodDetail(foodDetail);
            CheckFoodDetailId(foodDetail.ID);
            return foodDetailRepository.Update(foodDetail);
        }
        public bool Delete(int foodDetailID)
        {
            CheckFoodDetailId(foodDetailID);
            FoodDetail foodDetail = GetFoodDetailById(foodDetailID);
            return foodDetailRepository.Delete(foodDetail);
        }
        public bool Delete(FoodDetail foodDetail)
        {
            CheckFoodDetailId(foodDetail.ID);
            return foodDetailRepository.Delete(foodDetail);
        }
    }
}
