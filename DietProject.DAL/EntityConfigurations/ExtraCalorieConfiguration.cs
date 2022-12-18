using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class ExtraCalorieConfiguration : EntityTypeConfiguration<ExtraCalorie>
    {
        public ExtraCalorieConfiguration()
        {
            //onetomany
            HasMany(a => a.Meals).WithRequired(a => a.ExtraCalorie).HasForeignKey(a => a.ExtraCalorieID);
        }
    }
}
