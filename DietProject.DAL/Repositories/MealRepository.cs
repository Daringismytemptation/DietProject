
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class MealRepository
    {
        CaloriesDBContext context;
        public MealRepository()
        {
            context= new CaloriesDBContext();
        }
        public List<Meal> Meals()
        {
            return context.Meals.ToList();
        }
    }
}
