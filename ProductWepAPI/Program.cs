using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWepAPI
{
    public class Program
    {
        public IWebHostEnvironment HostingEnvironment { get; }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ProductDBContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnectionString"))
                ;
            });
            builder.Services.AddScoped<IProduct<Product>, ProductRepository>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Scope and activate DB Context Seeding method
            using (var scope = app.Services.CreateScope())
            {
                var _ctx = scope.ServiceProvider.GetRequiredService<ProductDBContext>();
                // Retrieve the IWebHostEnvironment for the Content Root
                var hostEnvironment = scope.ServiceProvider.GetRequiredService<IWebHostEnvironment>();
                _ctx.Seed(hostEnvironment.ContentRootPath);
            }


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
            //CreateHostBuilder(args).Build().Run();
        }



        // No longer needed if you use the scope factory pattern shown for seeding
        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}
