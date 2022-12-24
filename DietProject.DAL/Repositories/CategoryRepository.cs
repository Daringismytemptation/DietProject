
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class CategoryRepository
    {
        CaloriesDBContext context;
        public CategoryRepository()
        {
            context= new CaloriesDBContext();
        }
        public List<Category> Categories()
        {
            return context.Categories.ToList();
        }
        
    }
}
