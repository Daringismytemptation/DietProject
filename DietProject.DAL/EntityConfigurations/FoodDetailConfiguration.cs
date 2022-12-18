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
            //user onetomany
            HasRequired(a => a.User).WithMany(a => a.FoodDetails).HasForeignKey(a => a.UserID);
            //food manytomany
            HasMany(a => a.Foods).WithMany(a => a.FoodDetails);
        }
    }
}
