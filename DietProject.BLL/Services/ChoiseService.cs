using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DietProject.BLL.Services
{
    public class ChoiseService
    {
        ChoiseRepository choiseRepository;
        public ChoiseService()
        {
            choiseRepository = new ChoiseRepository();
        }
        public decimal GetCalorie(string foodName)
        {
            return choiseRepository.GetCalorie(foodName);
        }

        public bool Insert(Choise choise)
        {
            return choiseRepository.Insert(choise);
        }
       
        public bool Delete(int ID)
        {
        return choiseRepository.Delete(ID);
        }

        public Choise SelectChoice(int ID)
        {
            return choiseRepository.SelectChoice(ID);
        }

    }
}
