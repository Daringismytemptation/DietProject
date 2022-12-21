using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            //Foods many to many
            HasMany(a => a.Foods).WithMany(a => a.Meals);

            //Extra one to many
            HasRequired(a => a.ExtraCalorie).WithMany(a => a.Meals).HasForeignKey(a => a.ExtraCalorieID);
        }
    }
}
