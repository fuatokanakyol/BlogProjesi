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
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).IsRequired();
            builder.Property(x=>x.Title).HasMaxLength(150);
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.NetCore Deneme Makalesi",
                Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.",
                ViewCount=15,
                CategoryId= Guid.Parse("20C58B99-ECC0-4076-AA4D-6F8CB23A8C40"),
                ImageId= Guid.Parse("574542EA-0BE2-48BC-B1F2-B36574164E32"),
                
                CreatedBy="Admin Test",
                CreatedDate=DateTime.Now,
                IsDeleted = false

            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makale",
                Content = "Visual Studio Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır.",
                ViewCount = 15,
                
                CategoryId= Guid.Parse("BB65EA37-814C-44A5-9804-83B10B452B2E"),
                
                ImageId= Guid.Parse("FE54D4FA-05EE-4C8D-AABE-DCF2E19F3961"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            });
            
        }
    }
}
