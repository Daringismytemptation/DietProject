using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class DateConfiguration:EntityTypeConfiguration<Date>
    {
        public DateConfiguration()
        {
           
            HasMany(b => b.Choises).WithRequired(b => b.Date).HasForeignKey(a => a.DateID);
           //bir userın birden çok datesi olabilir ama bir date 1 usera aittir 
           HasRequired(b=>b.User).WithMany(b=>b.Dates).HasForeignKey(a => a.UserID);
           
            
        }
    }
}
