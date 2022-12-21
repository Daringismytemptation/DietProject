
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class ExtraCalorieRepository
    {
        CaloriesDBContext context;
        public ExtraCalorieRepository()
        {
            context = new CaloriesDBContext();
        }

        public List<ExtraCalorie> GetByUserId(int userID)
        {
            var user = context.Users.Where(a => a.ID == userID);
            var meal = context.Meals.Where(a => a.Users == user);
            var extra = context.ExtraCalories.Where(a => a.Meals == meal);
            return extra.ToList();
        }
        public ExtraCalorie GetByExtraCalorieId(int extraCalorieID)
        {
            return context.ExtraCalories.Find(extraCalorieID);
        }
        public bool Insert(ExtraCalorie extraCalorie)
        {
            context.ExtraCalories.Add(extraCalorie);
            return context.SaveChanges() > 0;
        }
        public bool Delete(ExtraCalorie extraCalorie)
        {
            var meal = context.Meals.Where(a => a.ExtraCalorieID == extraCalorie.ID);
            var user = context.Users.Where(a => a.Meals == meal).FirstOrDefault();
            context.Users.Remove(user);

            return context.SaveChanges() > 0;

        }
    }
}
