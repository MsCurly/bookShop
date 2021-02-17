using Microsoft.EntityFrameworkCore;
using bookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookShop.Data
{
    // ctrl + . ile ef yi hazır ekler
    public class bookShopDbContext : DbContext
    {
        public bookShopDbContext(DbContextOptions<bookShopDbContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                        .HasOne(p => p.Category)
                        .WithMany(c => c.Prdoucts)
                        .HasForeignKey(p => p.CategoryId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
