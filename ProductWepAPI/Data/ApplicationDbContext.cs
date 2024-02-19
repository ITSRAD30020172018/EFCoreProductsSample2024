using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWepAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public ApplicationDbContext() : base()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // Seeding to be done in Seeder after we add the context
            // Could also use options and app settings value here to set database 
            // which would be better for Azure deployment
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProductCoreDB-2024";
            optionsBuilder.UseSqlServer(myconnectionstring)
              .LogTo(Console.WriteLine,
                     new[] { DbLoggerCategory.Database.Command.Name },
                     LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }

        

    }
}
