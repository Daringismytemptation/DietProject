using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class PasswordRepository
    {
        CaloriesDBContext context;
        public PasswordRepository()
        {
            context = new CaloriesDBContext();
        }
        /// <summary>
        /// Son 3 şifreyi getirir
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>Password şifre listesi</returns>
        public List<Password> GetLastThreePasswords(int userID)
        {
            return context.Passwords.Where(a => a.UserID == userID).OrderByDescending(a => a.CreationDate).Take(3).ToList();
        }
        /// <summary>
        /// yeni şifre ekleme metodu
        /// </summary>
        /// <param name="password"></param>
        /// <returns>değişiklik varsa true döner</returns>
        public bool Insert(Password password)
        {
            context.Passwords.Add(password);
            return context.SaveChanges() > 0; //etkilenen satır
        }
        /// <summary>
        /// mevcut şifre
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>Password</returns>
        public Password GetActivePassword(int userID)
        {
            return context.Passwords.Where(a => a.UserID == userID).OrderByDescending(a => a.CreationDate).FirstOrDefault();
        }

    }
}
