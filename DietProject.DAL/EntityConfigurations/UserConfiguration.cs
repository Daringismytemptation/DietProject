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

            // Relations

            // Password one to many
            HasMany(a => a.Passwords).WithRequired(b => b.User).HasForeignKey(c => c.UserID);


            //Choise one to many
            HasMany(a=>a.Choises).WithRequired(b=>b.User).HasForeignKey(c => c.UserID);

            
        }
    }
}
