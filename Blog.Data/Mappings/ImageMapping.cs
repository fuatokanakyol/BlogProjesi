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
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
            {
                    Id= Guid.Parse("FE54D4FA-05EE-4C8D-AABE-DCF2E19F3961"),
                    FileName ="images/testİmage",
                    FileType="jpg",
                    CreatedBy="Admin Test",
                    CreatedDate=DateTime.Now,
                    IsDeleted=false
                    
            },
            new Image
            {
                Id = Guid.Parse("574542EA-0BE2-48BC-B1F2-B36574164E32"),
                FileName = "images/testİmage",
                FileType = "png",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
        }
    }
}
