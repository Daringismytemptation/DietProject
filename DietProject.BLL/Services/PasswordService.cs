using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Services
{
    public class PasswordService
    {
        PasswordRepository passwordRepository;
        public PasswordService()
        {
            passwordRepository = new PasswordRepository();
        }
        /// <summary>
        /// son 3 şifreyle aynı olma kontrolü
        /// </summary>
        /// <param name="password"></param>
        /// <returns>true/false</returns>
        /// <exception cref="Exception"></exception>
        bool CheckLastThreePasswords(Password password)
        {
            List<Password> lastThreePasswords = passwordRepository.GetLastThreePassword((int)password.UserID);
            foreach (var item in lastThreePasswords)
            {
                if (item.UserPassword == password.UserPassword) throw new Exception("Bu şifre son üç şifreden biri");
            }
            return true;
        }
        /// <summary>
        /// yeni şifre ekleme
        /// </summary>
        /// <param name="password"></param>
        /// <returns>true/false</returns>
        public bool Insert(Password password)
        {
            if (CheckLastThreePasswords(password))
            {
                password.CreationDate = DateTime.Now;
                return passwordRepository.Insert(password);
            }
            return false;
        }
        /// <summary>
        /// şuan kullandıgı şifre
        /// </summary>
        /// <param name="userID"></param>
        /// <returns>Password</returns>
        /// <exception cref="Exception"></exception>
        public Password GetActivePassword(int userID)
        {
            if (userID <= 0) throw new Exception("Parametre geçersiz");
            return passwordRepository.GetActivePassword(userID);
        }
    }
}
