using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Services
{
    public class CategoryService
    {
        FoodRepository foodRepository;
        CategoryRepository categoryRepository;
        public CategoryService()
        {
            categoryRepository= new CategoryRepository();
            foodRepository= new FoodRepository();
        }
        public List<Category> Categories()
        {
            return categoryRepository.Categories();
        }
       
    }
}
