using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Ioc.Core.Data;

namespace Ioc.Data.Mapping
{
    public class UserProfileMap : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            HasKey(t => t.ID);
            Property(t => t.FirstName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.FirstName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
            Property(t => t.AddedDate).IsRequired();
            Property(t => t.Address).HasColumnType("nvarchar");
            Property(t => t.ModifiedDate).IsRequired();
            Property(t => t.IP);
            ToTable("UserProfile");
            HasRequired(t => t.User).WithRequiredDependent(u => u.UserProfile);

        }
    }
}
