
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class CategoryRepository
    {
        CaloriesDBContext context;
        public CategoryRepository()
        {
            context = new CaloriesDBContext();
        }

        /// <summary>
        /// userid parametresine göre seçmiş oldugu categories.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>List<Category></returns>
        public List<Category> GetByUserId(int userID)
        {
            var foodDetails = context.FoodDetails.Where(a => a.UserID == userID);
            var foods = context.Foods.Where(a => a.FoodDetails == foodDetails);
            var category = context.Categories.Where(a => a.Foods == foods);
            return category.ToList();
        }
        /// <summary>
        /// categoryId'ye sahip category i bul-ver.update
        /// </summary>
        /// <param name="noteID"></param>
        /// <returns>Category</returns>
        public Category GetByCategoryId(int categoryID)
        {
            return context.Categories.Find(categoryID);
        }
        /// <summary>
        /// CategoryNameUpdate
        /// </summary>
        /// <param name="category"></param>
        /// <returns>true/false</returns>
        public bool Update(Category category)
        {
            Category updateCategory = GetByCategoryId(category.ID);
            updateCategory.Name = category.Name;
            return context.SaveChanges() > 0;
        }
        /// <summary>
        /// category eklemek için
        /// </summary>
        /// <param name="category"></param>
        /// <returns>true/false</returns>
        public bool Insert(Category category)
        {
            context.Categories.Add(category);
            return context.SaveChanges() > 0;
        }
        //*****
        public bool Delete(Category category)
        {
            var foods = context.Foods.Where(a => a.CategoryID == category.ID);
            var foodDetails = context.FoodDetails.Where(a => a.Foods == foods);
            var user = context.Users.Where(a => a.FoodDetails == foodDetails).FirstOrDefault();
            context.Users.Remove(user);

            return context.SaveChanges() > 0;

        }
    }
}
