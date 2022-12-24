
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class FoodRepository
    {
        CaloriesDBContext context;
        public FoodRepository()
        {
            context= new CaloriesDBContext();
        }
        public List<Food> foods(string category)
        {
            var foodList = context.Foods.Where(a => a.Category.Name == category);
            return foodList.ToList();
        }
    }
}
