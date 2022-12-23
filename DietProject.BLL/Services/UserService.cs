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
            userRepository= new UserRepository();
        }
        public bool Insert(User user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName) || string.IsNullOrWhiteSpace(user.Email))
            {
                throw new Exception("Eksik alan doldurdunuz.");
            }
            Password firstPassword = user.Passwords.FirstOrDefault();
            if (firstPassword == null)
            {
                throw new Exception("Şifre giriniz");
            }



            user.Passwords.FirstOrDefault().CreationDate = DateTime.Now;
            user.IsActive = false;
            user.UserType = EnumUser.Standart;
            return userRepository.Insert(user);
        }
    }
}
