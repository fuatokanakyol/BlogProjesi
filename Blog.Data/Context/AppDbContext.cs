using Blog.Data.Mappings;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //En basit yöntem:
            //modelBuilder.Entity<Article>().Property(x => x.Id).IsRequired();
            //2.Yöntem
            //modelBuilder.ApplyConfiguration(new ArticleMap());
            //((Tüm mappingleri bulunduğumuz assembly üzerinden hepsini çağırırız))
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
