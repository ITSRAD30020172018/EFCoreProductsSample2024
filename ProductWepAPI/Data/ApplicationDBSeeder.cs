using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using ProductModel;
using ProductWepAPI.Data;

namespace ProductSeeding
{
  public class ApplicationDbSeeder
  {
    private readonly ApplicationDbContext _ctx;

        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationDbSeeder(ApplicationDbContext ctx,UserManager<ApplicationUser> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }
        public async Task Seed()
        {
            // Migrations have to be updated as two contexts
          _ctx.Database.EnsureCreated();
                // Seed the Main User
                ApplicationUser user = await _userManager.FindByEmailAsync("paul@itsligo.ie");
                if (user == null)
                {
                user = new ApplicationUser()
                {
                        Id = Guid.NewGuid().ToString(),
                        SecondName = "Powell",
                        FirstName = "Paul",
                        Email = "paul@itsligo.ie",
                        UserName = "paul@itsligo.ie",
                        EmailConfirmed = true,
                        SecurityStamp = Guid.NewGuid().ToString(),
                    };

                    var result = await _userManager.CreateAsync(user, "P@ssw0rd!");
                    if (result != IdentityResult.Success)
                    {
                        throw new InvalidOperationException("Could not create user in Seeding");
                    }
                    _ctx.SaveChanges();
                }
        }
    }
}

