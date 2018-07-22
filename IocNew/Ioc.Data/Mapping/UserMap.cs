using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ioc.Core.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
namespace Ioc.Data.Mapping
{
    public class UserMap :EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(t => t.ID);
            Property(t => t.UserName).IsRequired();
            Property(t => t.Email).IsRequired();
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.ModifiedDate).IsRequired();
            Property(t => t.IP);
            ToTable("User");
        }
    }
}
