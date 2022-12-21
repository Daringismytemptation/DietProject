using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            context = new CaloriesDBContext();
        }
        /// <summary>
        /// Database'e kayıt etme,eğer kayıt varsa (satırlarda bir değişiklik varsa) true dönecek
        /// </summary>
        /// <param name="user"></param>
        /// <returns>bool</returns>
        public bool Insert(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges() > 0;
        }

        /// <summary>
        /// usermail ve şifre doğruluğu
        /// </summary>
        /// <param name="eMail"></param>
        /// <param name="password"></param>
        /// <returns>User</returns>
        public User CheckLogin(string eMail, string password)
        {
            User user = context.Users.Where(a => a.Email == eMail).SingleOrDefault();
            if (user != null)
            {
                Password userPassword = passwordRepository.GetActivePassword(user.ID);
                if (userPassword != null)// && userPassword.Text == password)
                {
                    return user;
                }
            }
            return null;
        }
        /// <summary>
        /// adminin Activeyi true döndürme durumu
        /// </summary>
        /// <param name="user"></param>
        public void ActivateUser(User user)
        {
            User activatedUser = GetUserById(user.ID);
            activatedUser.IsActive = true;
            context.SaveChanges();
        }
        /// <summary>
        /// Kayıt olanları adminin onaylama listesi
        /// </summary>
        /// <returns>PasifOlanUserListi döner</returns>
        public List<User> GetPassiveUser()
        {
            return context.Users.Where(a => !a.IsActive).ToList();
        }
        /// <summary>
        /// int değerinde bir id parametresi alır. Parametre olarak gönderilen idye karşılık User bilgileri döner
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>User</returns>
        public User GetUserById(int userID)
        {
            return context.Users.Find(userID);
        }
    }
}
