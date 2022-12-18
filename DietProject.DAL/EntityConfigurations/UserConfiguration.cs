using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(a => a.FirstName).IsRequired().HasMaxLength(50);
            Property(a => a.LastName).IsRequired().HasMaxLength(50);

            Property(a => a.Email).IsRequired();
            //HasIndex(a => a.Email).IsUnique();

            Property(a => a.Age).IsRequired();

            //relations

            //password onetomany
            HasMany(a => a.Passwords).WithRequired(b => b.User).HasForeignKey(c => c.UserID);

            //food detail onetomany
            HasMany(a => a.FoodDetails).WithRequired(a => a.User).HasForeignKey(c => c.UserID);

            //meal manytomany
            HasMany(a => a.Meals).WithMany(b => b.Users);



        }
    }
}
