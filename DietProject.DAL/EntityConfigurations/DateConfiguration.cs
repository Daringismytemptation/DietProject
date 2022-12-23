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
            HasMany(a => a.Users).WithMany(a => a.Dates);
        }
    }
}
