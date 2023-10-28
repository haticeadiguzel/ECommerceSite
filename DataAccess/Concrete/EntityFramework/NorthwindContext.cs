using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext //Entity framework'te var
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=172.17.0.2; Port=5432; Username=hatice; Password=ataturk; Database=Northwind");
            //Trusted_Connection Kullanıcı adı şifre gerektirmez
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasNoKey();
            modelBuilder.Entity<Category>().HasNoKey();
            modelBuilder.Entity<Customer>().HasNoKey();
            modelBuilder.Entity<Order>().HasNoKey();
        }


        //DbSet ile veritabanındaki tabloya karşılık gelen entity eşlenir
        public DbSet<Product> products { get; set; } 
        public DbSet<Category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
    }
}
