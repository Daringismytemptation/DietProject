using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.Strategy
{
    public class CaloriesStrategy:CreateDatabaseIfNotExists<CalorieDBContext>
    {
        protected override void Seed(CalorieDBContext context)
        {

        }
    }
}
