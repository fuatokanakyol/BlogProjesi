using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("BB65EA37-814C-44A5-9804-83B10B452B2E"),
                Name = "Visual Studio 2022",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("20C58B99-ECC0-4076-AA4D-6F8CB23A8C40"),
                Name = "Asp.Net Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            }
            );
        }
    }
}
