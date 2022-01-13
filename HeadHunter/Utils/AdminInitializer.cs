using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using HeadHunter.Entities;

namespace HeadHunter.Utils
{
    public class AdminInitializer
    {
        public static async Task SeedAdminUser(
              RoleManager<IdentityRole> _roleManager,
              UserManager<User> _userManager)
        {
            var adminEmail = "admin@admin.com";
            var adminPassword = "password";
            var roles = new[] { "admin", "employer", "jobSeeker" };

            foreach (var role in roles)
                if (await _roleManager.FindByNameAsync(role) is null)
                    await _roleManager.CreateAsync(new IdentityRole(role));

            if (await _userManager.FindByEmailAsync(adminEmail) == null)
            {
                User admin = new User { 
                    Email = adminEmail, UserName = adminEmail 
                };

                IdentityResult result = await _userManager.CreateAsync(admin, adminPassword);
                
                if (result.Succeeded)
                    await _userManager.AddToRoleAsync(admin, "admin");
            }
        }
    }
}
