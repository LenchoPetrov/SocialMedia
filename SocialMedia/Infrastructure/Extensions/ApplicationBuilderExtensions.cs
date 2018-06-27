namespace SocialMedia.Infrastructure.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using System;
    using System.Threading.Tasks;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDatabaseMigrations(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetService<SocialMediaDbContext>().Database.Migrate();

                var userManager = serviceScope.ServiceProvider.GetService<UserManager<User>>();
                var roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                Task.Run(async () =>
                {
                    var adminName = GlobalConstants.AdministratorRole;
                    
                    var adminExists = await roleManager.RoleExistsAsync(adminName);
                
                    if (!adminExists)
                    {
                        await roleManager.CreateAsync(new IdentityRole
                        {
                            Name = adminName
                        });
                    }


                    var adminUser = await userManager.FindByEmailAsync("admin@mail.bg");

                    if (adminUser == null)
                    {
                        adminUser = new User
                        {
                            Email = "admin@mail.bg",
                            UserName = "admin",
                            Name = "Georgi Georgiev",
                            BirthDate = new DateTime(1980, 1, 20)
                        };

                        await userManager.CreateAsync(adminUser, "123456");

                        await userManager.AddToRoleAsync(adminUser, adminName);

                        adminUser = new User
                        {
                            Email = "admin2@mail.bg",
                            UserName = "admin2",
                            Name = "Joro Jorev",
                            BirthDate = new DateTime(1978, 8, 20)
                        };

                        await userManager.CreateAsync(adminUser, "123456");

                        await userManager.AddToRoleAsync(adminUser, adminName);
                    }     
                }).Wait();
            }
            return app;
        }
    }
}
