using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class FoodDetailConfiguration : EntityTypeConfiguration<FoodDetail>
    {
        public FoodDetailConfiguration()
        {
            

            // Food many to many
            HasMany(a => a.Foods).WithMany(a => a.FoodDetails);
        }
    }
}
