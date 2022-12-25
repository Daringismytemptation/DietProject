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
        PasswordRepository passwordRepository;
        public UserRepository()
        {
           context= new CaloriesDBContext();
           passwordRepository= new PasswordRepository();
        }
        public bool Insert(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges() > 0;
        }
        public User CheckLogin(string userName, string password)
        {
            User user = context.Users.Where(a => a.Email == userName).SingleOrDefault();
            if (user != null)
            {
                Password userPassword = passwordRepository.GetActivePassword(user.ID);
                if (userPassword != null && userPassword.UserPassword == password)
                {
                    return user;
                }
            }
            return null;
        }
        public List<User> GetPassiveUsers()
        {
            return context.Users.Where(a=> !a.IsActive).ToList();
        }

        public User GetUserById(int userID)
        {
            return context.Users.Find(userID);
        }
        public void ActivateUser(User user)
        {
            User activatedUser = GetUserById(user.ID);
            activatedUser.IsActive = true;
            context.SaveChanges();
        }

        public List<User> CheckEmailIfExists(string eMail)
        {
            return context.Users.Where(x => x.Email == eMail).ToList();

        }
        public string FindEmailIfExists(string eMail)
        {
           return context.Users.Where(a => a.Email.Contains(eMail)).Select(x => x.Email).First().ToString();
        }

    }
}
