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
        CategoryRepository categoryRepository;
        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }
        public List<Category> GetById(int userID)
        {
            List<Category> categories = new List<Category>();
            if (userID > 0)
            {
                categories = categoryRepository.GetByUserId(userID);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
            return categories;
        }
        void CheckCategoryId(int categoryID)
        {
            if (categoryID <= 0) throw new Exception("Parametre değeri uygun değil");
        }
        public Category GetCategoryById(int categoryID)
        {
            Category category = new Category();
            CheckCategoryId(categoryID);
            category = categoryRepository.GetByCategoryId(categoryID);
            return category;
        }
        void SelectedCategory(Category category)
        {
            if (string.IsNullOrEmpty(category.Name)) throw new Exception("Kategori seçiniz");
        }
        public bool Insert(Category category)
        {
            SelectedCategory(category);
            category.CreationDate = DateTime.Now;
            return categoryRepository.Insert(category);
        }
        public bool Update(Category category)
        {
            CheckCategoryId(category.ID);
            return categoryRepository.Update(category);
        }
        public bool Delete(Category category)
        {
            CheckCategoryId(category.ID);
            return categoryRepository.Delete(category);
        }
        public bool Delete(int categoryID)
        {
            CheckCategoryId(categoryID);
            Category category = GetCategoryById(categoryID);
            return categoryRepository.Delete(category);
        }
    }
}
