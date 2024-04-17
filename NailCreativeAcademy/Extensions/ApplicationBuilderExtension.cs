namespace Microsoft.AspNetCore.Builder
{
    using Microsoft.AspNetCore.Identity;
    using NailCreativeAcademy.Infrastructure.Data.Models;
    using static NailCreativeAcademy.Core.Constants.AdminConstants;

    public static class ApplicationBuilderExtensions
    {
        public static async Task CreateAdminRoleAsync(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            UserManager<ApplicationUser> userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(RoleAdmin) == false)
            {
                var role = new IdentityRole(RoleAdmin);
                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByEmailAsync("t_nikolova1985@abv.bg");

                if (admin != null)
                {
                    await userManager.AddToRoleAsync(admin, role.Name);
                }
            }

        }
    }
}
