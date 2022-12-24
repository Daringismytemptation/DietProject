using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.DAL.EntityConfigurations
{
    public class ChoiseConffiguration:EntityTypeConfiguration<Choise>
    {
        public ChoiseConffiguration()
        {
            //
            HasRequired(a=>a.User).WithMany(b=>b.Choises).HasForeignKey(a=>a.UserID);

            Property(a => a.RelevantDate).HasColumnType("date");
            
        }
    }
}
