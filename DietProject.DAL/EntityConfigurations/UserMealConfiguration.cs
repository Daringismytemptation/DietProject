using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class UserMealConfiguration: EntityTypeConfiguration<UserMeal>
    {
        public UserMealConfiguration()
        {
            //
            Property(a => a.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasOptional(a => a.Meal).WithMany(b => b.UserMeals);
            HasOptional(a => a.User).WithMany(b => b.UserMeals);
        }
    }
}
