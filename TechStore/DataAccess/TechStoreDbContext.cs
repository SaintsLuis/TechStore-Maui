using TechStore.Models;
using TechStore.Utils;
using Microsoft.EntityFrameworkCore;

namespace TechStore.DataAccess
{
    public class TechStoreDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Advertisements> Advertisements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string pathDB = ConexionDB.DevolverRuta("TechStore.db3");
            optionsBuilder.UseSqlite($"Filename={pathDB}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

        }

    }
}