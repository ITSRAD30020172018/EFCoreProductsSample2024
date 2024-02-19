
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductModel
{
    public class ProductDBContext : DbContext
    {
         public DbSet<Product> Products { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        static public bool inProduction;
        public ProductDBContext()
        {
            
        }
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {
            // Seeding to be done in Seeder after we add the context
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProductCoreDB-2024";
            optionsBuilder.UseSqlServer(myconnectionstring)
              .LogTo(Console.WriteLine,
                     new[] { DbLoggerCategory.Database.Command.Name },
                     LogLevel.Information);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // NOTE: this line is activated from the bin folder whihc is a sub
            // folder of the class library project
            // You must build the project before calling Add-migration

            // Data will be seeded using DB Seeder
            //if (!inProduction)
            //{
            //    Product[] products = DBHelper.Get<Product>(@"..\ProductModel\Products.csv").ToArray();
            //    modelBuilder.Entity<Product>().HasData(products);
            //}
            //modelBuilder.Entity<Product>().HasData(
            // new Product
            // {
            //     ID = 46,
            //     Description = "test",
            //     ReorderLevel = 4,
            //     ReorderQuantity = 2,
            //     StockOnHand = 30,
            //     UnitPrice = 10
            // });

            base.OnModelCreating(modelBuilder);
        }


    }
}


