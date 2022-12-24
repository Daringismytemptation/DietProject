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
            foodRepository= new FoodRepository();
        }
        public List<Food> foods(string categoryName)
        {
            return foodRepository.foods(categoryName);
        }
    }
}
