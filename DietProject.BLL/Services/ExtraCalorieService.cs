using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.BLL.Services
{
    public class ExtraCalorieService
    {
        ExtraCalorieRepository extraCalorieRepository;
        public ExtraCalorieService()
        {
            extraCalorieRepository = new ExtraCalorieRepository();
        }
        public List<ExtraCalorie> GetById(int userID)
        {
            List<ExtraCalorie> extraCalories = new List<ExtraCalorie>();
            if (userID > 0)
            {
                extraCalories = extraCalorieRepository.GetByUserId(userID);
            }
            else
            {
                throw new Exception("Parametre değeri uygun değil");
            }
            return extraCalories;
        }
        void CheckExtraCalorieId(int extraCalorieID)
        {
            if (extraCalorieID <= 0)
            {
                throw new Exception("Parametre değeri uygun değil");
            }
        }
        public ExtraCalorie GetExtraCalorieById(int extraCalorieID)
        {
            ExtraCalorie extraCalorie = new ExtraCalorie();
            CheckExtraCalorieId(extraCalorieID);
            extraCalorie = extraCalorieRepository.GetByExtraCalorieId(extraCalorieID);
            return extraCalorie;
        }
        //void CheckExtraCalori(ExtraCalorie extraCalorie)
        //{
        //    if (string.IsNullOrWhiteSpace(extraCalorie.Calorie.ToString()))
        //    {
        //        throw new Exception("ekstraCalorie girmediniz");
        //    }
        //}
        public bool Insert(ExtraCalorie extraCalorie)
        {
            extraCalorie.CreationDate = DateTime.Now;
            return extraCalorieRepository.Insert(extraCalorie);
        }
        public bool Update(ExtraCalorie extraCalorie)
        {
            CheckExtraCalorieId(extraCalorie.ID);
            return extraCalorieRepository.Update(extraCalorie);
        }
        public bool Delete(ExtraCalorie extraCalorie)
        {
            CheckExtraCalorieId(extraCalorie.ID);
            return extraCalorieRepository.Delete(extraCalorie);
        }
        public bool Delete(int extraCalorieId)
        {
            CheckExtraCalorieId(extraCalorieId);
            ExtraCalorie extraCalorie = GetExtraCalorieById(extraCalorieId);
            return extraCalorieRepository.Delete(extraCalorie);
        }
    }
}
