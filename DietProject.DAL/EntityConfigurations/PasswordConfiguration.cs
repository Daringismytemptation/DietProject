using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class PasswordConfiguration : EntityTypeConfiguration<Password>
    {
        public PasswordConfiguration()
        {
            //User one to many
            Property(a => a.UserPassword).IsRequired().HasMaxLength(20);
            HasRequired(a => a.User).WithMany(a => a.Passwords).HasForeignKey(a => a.UserID);
        }
    }
}
