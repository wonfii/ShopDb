using hw_ShopDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_ShopDb.Helpers
{
    public static class DbInitializer
    {
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
               new Country { CountryId = 1, Name = "USA" },
               new Country { CountryId = 2, Name = "Canada" }
           );
        }

        public static void SeedCities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, Name = "New York", CountryId = 1 },
                new City { CityId = 2, Name = "Los Angeles", CountryId = 1 },
                new City { CityId = 3, Name = "Toronto", CountryId = 2 }
            );
        }

        public static void SeedShops(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop>().HasData(
                new Shop { ShopId = 1, Name = "TechStore", Address = "123 Tech Road", CityId = 1 },
                new Shop { ShopId = 2, Name = "BookStore", Address = "456 Book Street", CityId = 2 }
            );
        }

        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Electronics" },
                new Category { CategoryId = 2, Name = "Books" }
            );
        }

        public static void SeedProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
               new Product { ProductId = 1, Name = "Laptop", Price = 999.99m, CategoryId = 1 },
               new Product { ProductId = 2, Name = "Smartphone", Price = 499.99m, CategoryId = 1 },
               new Product { ProductId = 3, Name = "Fiction Book", Price = 19.99m, CategoryId = 2 }
           );
        }

        public static void SeedPositions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Position>().HasData(
               new Position { PositionId = 1, Name = "Manager" },
               new Position { PositionId = 2, Name = "Cashier" }
           );
        }

        public static void SeedWorkers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Worker>().HasData(
               new Worker
               {
                   WorkerId = 1,
                   Name = "John",
                   Surname = "Doe",
                   Email = "john.doe@example.com",
                   PhoneNumber = "555-1234",
                   Salary = 60000,
                   ShopId = 1,
                   PoditionId = 1
               },
               new Worker
               {
                   WorkerId = 2,
                   Name = "Jane",
                   Surname = "Smith",
                   Email = "jane.smith@example.com",
                   PhoneNumber = "555-5678",
                   Salary = 45000,
                   ShopId = 2,
                   PoditionId = 2
               },
               new Worker
               {
                   WorkerId = 3,
                   Name = "Mike",
                   Surname = "Johnson",
                   Email = "mike.johnson@example.com",
                   PhoneNumber = "555-8765",
                   Salary = 40000,
                   ShopId = 1,
                   PoditionId = 2
               }
           );
        }
    }
}
