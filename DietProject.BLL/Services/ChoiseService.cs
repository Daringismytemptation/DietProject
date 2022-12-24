using DietProject.DAL.Repositories;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

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
        public List<Choise> Choises()
        {
            return choiseRepository.Choises();
        }
    }
}
