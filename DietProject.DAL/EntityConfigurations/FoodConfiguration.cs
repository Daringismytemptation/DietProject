using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class FoodConfiguration : EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {
            //category onetomany
            HasRequired(a => a.Category).WithMany(a => a.Foods).HasForeignKey(a => a.CategoryID);

        }
    }
}
