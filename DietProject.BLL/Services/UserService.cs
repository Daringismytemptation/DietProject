using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using DietProject.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public bool Insert(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Age.ToString()) || string.IsNullOrWhiteSpace(user.Height.ToString()) || string.IsNullOrWhiteSpace(user.Weight.ToString()))
            {
                throw new Exception("Eksik alan doldurdunuz.");
            }
            Password firstPassword = user.Passwords.FirstOrDefault();
            if (firstPassword == null)
            {
                throw new Exception("Şifre giriniz");
            }
            user.CreationDate = DateTime.Now;

            user.Passwords.FirstOrDefault().CreationDate = DateTime.Now;
            user.IsActive = false;
            user.UserType = EnumUser.Users;
            return userRepository.Insert(user);
        }
        public User CheckLogin(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("username ve/veya password eksik");
            }
            return userRepository.CheckLogin(userName, password);
        }
        void CheckUserId(User user)
        {
            if (user.ID <= 0) throw new Exception("User id boş olamaz");
        }
        public void ActivateUser(User user)
        {
            CheckUserId(user);
            userRepository.ActivateUser(user);
        }
        public void ActivateUser(int userID)
        {
            User user = userRepository.GetUserById(userID);
            CheckUserId(user);
            userRepository.ActivateUser(user);
        }
        public List<User> GetPassiveUsers()
        {
            return userRepository.GetPassiveUser();
        }
    }
}
