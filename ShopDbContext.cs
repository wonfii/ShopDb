using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw_ShopDb.Entities;
using hw_ShopDb.Helpers;
using Microsoft.EntityFrameworkCore;

namespace hw_ShopDb
{
    public class ShopDbContext : DbContext
    {

        public DbSet<Category> Category { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Worker> Worker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                        Initial Catalog=master;
                                        Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;
                                        Trust Server Certificate=False;
                                        Application Intent=ReadWrite;
                                        Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Fluent API

            // city
            modelBuilder.Entity<City>()
                .Property(ct => ct.Name)
                .HasMaxLength(60)
                .IsRequired();

            // shop
            modelBuilder.Entity<Shop>()
                .Property(sh => sh.Name)
                .HasMaxLength(60)
                .IsRequired();

            modelBuilder.Entity<Shop>()
                .Property(sh => sh.Address)
                .HasMaxLength(150)
                .IsRequired();

            // country
            modelBuilder.Entity<Country>()
                .Property(c => c.Name)
                .HasMaxLength(60)
                .IsRequired();

            // worker
            modelBuilder.Entity<Worker>()
                .Property(w => w.Name)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Worker>()
                .Property(w => w.Surname)
                .HasMaxLength(80)
                .IsRequired();

            modelBuilder.Entity<Worker>()
                .Property(w => w.Email)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Worker>()
               .Property(w => w.PhoneNumber)
               .HasMaxLength(50)
               .IsRequired();

            modelBuilder.Entity<Worker>()
               .Property(w => w.Salary)
               .IsRequired();

            // position 

            modelBuilder.Entity<Position>()
               .Property(w => w.Name)
               .HasMaxLength(50)
               .IsRequired();

            // product

            modelBuilder.Entity<Product>()
              .Property(pr => pr.Name)
              .HasMaxLength(100)
              .IsRequired();

            modelBuilder.Entity<Product>()
              .Property(pr => pr.Price)              
              .IsRequired();

            // category 

            modelBuilder.Entity<Category>()
              .Property(ctg => ctg.Name)
              .HasMaxLength(50)
              .IsRequired();


            //Relationship Configuration

            //Shop - City (* - 1)

            modelBuilder.Entity<Shop>().
                HasOne(sh => sh.City)
                .WithMany(ct => ct.Shops)
                .HasForeignKey(sh => sh.CityId);

            // City - Country (* - 1)

            modelBuilder.Entity<City>()
                .HasOne(ct => ct.Country)
                .WithMany(c => c.Cities)
                .HasForeignKey(ct => ct.CountryId);

            // Worker - Shop (* - 1)

            modelBuilder.Entity<Worker>()
                .HasOne(w => w.Shop)
                .WithMany(sh => sh.Workers)
                .HasForeignKey(w => w.ShopId);

            // Worker - Position (* - 1)

            modelBuilder.Entity<Worker>()
                .HasOne(w => w.Position)
                .WithMany(p => p.Workers)
                .HasForeignKey(w => w.PoditionId);

            // Shop - Product (* - *)

            modelBuilder.Entity<Shop>()
                .HasMany(sh => sh.Products)
                .WithMany(pr => pr.Shops);

            // Product - Category (* - 0..1)

            modelBuilder.Entity<Product>()
                .HasOne(pr => pr.Category)
                .WithMany(ctg => ctg.Products)
                .HasForeignKey(pr => pr.CategoryId)
                .IsRequired(false);


            //Initialization - Seeder
            modelBuilder.SeedCountries();
            modelBuilder.SeedCities();
            modelBuilder.SeedShops();
            modelBuilder.SeedCategories();
            modelBuilder.SeedProducts();
            modelBuilder.SeedPositions();
            modelBuilder.SeedWorkers();

        }

    }
}
