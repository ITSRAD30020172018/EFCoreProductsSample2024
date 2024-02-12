using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            Database.EnsureDeleted();
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProductCoreDB";
            //optionsBuilder.UseSqlServer(myconnectionstring)
            //  .LogTo(Console.WriteLine,
            //         new[] { DbLoggerCategory.Database.Command.Name },
            //         LogLevel.Information);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.UseIdentityColumns(1, 1);
            // NOTE: this line is activated from the bin folder whihc is a sub
            // folder of the class library project
            // You must build the project before calling Add-migration
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

        public void Seed(string contentRootPath)
        {
            // _ctx.Database.EnsureDeleted();
            this.Database.EnsureCreated();

            if (!this.Suppliers.Any())
            {
                // Need to create sample data
                var filepath = Path.Combine(contentRootPath, "Data/Supplier.json");
                var json = File.ReadAllText(filepath);
                var suppliers = JsonConvert.DeserializeObject<IEnumerable<Supplier>>(json);
                this.Suppliers.AddRange(suppliers);
            }
            if (!this.Products.Any())
            {
                //int MaxId = _ctx.Products.Max(p => p.ID); // Alternative to using Autonumbered keys
                var filepath = Path.Combine(contentRootPath, "Data/Products.csv");
                Product[] products = DBHelper.Get<Product>(filepath).ToArray();
                this.Products.AddRange(products);


                this.SaveChanges();

            }
        }

        
    }
}


