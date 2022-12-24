using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Repositories
{
    public class ChoiseRepository
    {
        CaloriesDBContext context;
        public ChoiseRepository()
        {
            context = new CaloriesDBContext();
        }

        public decimal GetCalorie(string foodName)
        {
            return context.Foods.Where(x => x.Name == foodName).Select(a => a.CalorieAmountPer100gr).FirstOrDefault();
        }
        public bool Insert(Choise choise)
        {
            context.Choises.Add(choise);
            return context.SaveChanges() > 0;
        }
       
        public bool Delete(int gelenId)
        {
            
            var delete = context.Choises.Where(x=> x.ID == gelenId).FirstOrDefault();

            context.Choises.Remove(delete); 
            
            return context.SaveChanges() > 0;
        }

        public Choise SelectChoice(int ID)
        {
            return context.Choises.Where(x => x.ID == ID).FirstOrDefault();
            
        }

    }
}
