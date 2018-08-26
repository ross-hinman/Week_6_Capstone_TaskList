using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Domain.Models;
using System.Data.Entity.ModelConfiguration;


namespace TaskList.Data.Maps
{
    internal class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(x => x.Tasks).WithRequired(x => x.User).HasForeignKey(x => x.UserId);
        }
    }
}
