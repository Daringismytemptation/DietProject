using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class UserRepository
    {
        CaloriesDBContext context;
        public UserRepository()
        {
           context= new CaloriesDBContext();
        }
        public bool Insert(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges() > 0;
        }
    }
}
