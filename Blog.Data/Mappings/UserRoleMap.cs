using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("29C9DA8D-2679-4DE3-98E6-EA743DC1F305"),
                RoleId= Guid.Parse("C65ADA3D-78D7-4A0B-91CF-4DD7FF1A2859")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("DC6CBEBB-D03F-4E35-B488-EDB8D4C94381"),
                RoleId= Guid.Parse("72567069-BCDB-4CB9-B316-47302627FBDD")
            }
            );
        }
    }
}
