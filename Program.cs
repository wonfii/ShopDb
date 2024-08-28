using Microsoft.EntityFrameworkCore;

namespace hw_ShopDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ShopDbContext())
            {
                // Apply migrations and seed the database
                context.Database.Migrate();

                // Display data from the database
                DisplayData(context);
            }
        }

        static void DisplayData(ShopDbContext context)
        {
            // Display countries
            var countries = context.Country.ToList();
            Console.WriteLine("Countries:");
            foreach (var country in countries)
            {
                Console.WriteLine($"- {country.Name}");
            }

            // Display cities
            var cities = context.City.Include(c => c.Country).ToList();
            Console.WriteLine("\nCities:");
            foreach (var city in cities)
            {
                Console.WriteLine($"- {city.Name}, Country: {city.Country.Name}");
            }

            // Display shops
            var shops = context.Shop.Include(s => s.City).Include(s => s.Workers).Include(s => s.Products).ToList();
            Console.WriteLine("\nShops:");
            foreach (var shop in shops)
            {
                Console.WriteLine($"- {shop.Name}, Address: {shop.Address}, City: {shop.City.Name}");
                Console.WriteLine("  Workers:");
                foreach (var worker in shop.Workers)
                {                   
                    Console.WriteLine($"    {worker.Name} {worker.Surname}, Salary: {worker.Salary}");
                }                
                Console.WriteLine();
            }

            // Display workers
            var workers = context.Worker.Include(w => w.Position).Include(w => w.Shop).ToList();
            Console.WriteLine("\nWorkers:");
            foreach (var worker in workers)
            {
                string positionName = worker.Position != null ? worker.Position.Name : "Unknown";
                string shopName = worker.Shop != null ? worker.Shop.Name : "No Shop";
                Console.WriteLine($"{worker.Name} {worker.Surname}, Email: {worker.Email}, Phone: {worker.PhoneNumber}, Shop: {shopName}, Position: {positionName}, Salary: {worker.Salary}");
            }

            // Display products
            var products = context.Product.Include(p => p.Category).ToList();
            Console.WriteLine("\nProducts:");
            foreach (var product in products)
            {
                string categoryName = product.Category != null ? product.Category.Name : "No Category";
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}$, Category: {categoryName}");
            }
        }


    }
}
