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
                    //var authorName = GlobalConstants.AuthorRole;
                    //var trainerName = GlobalConstants.TrainerRole;

                    var adminExists = await roleManager.RoleExistsAsync(adminName);
                    //var authorExists = await roleManager.RoleExistsAsync(authorName);
                    //var trainerExists = await roleManager.RoleExistsAsync(trainerName);

                    if (!adminExists)
                    {
                        await roleManager.CreateAsync(new IdentityRole
                        {
                            Name = adminName
                        });
                    }
                    //if (!authorExists)
                    //{
                    //    await roleManager.CreateAsync(new IdentityRole
                    //    {
                    //        Name = authorName
                    //    });
                    //}

                    //if (!trainerExists)
                    //{
                    //    await roleManager.CreateAsync(new IdentityRole
                    //    {
                    //        Name = trainerName
                    //    });
                    //}


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

                    //var authorUser = new User
                    //{
                    //    Email = "test@mail.bg",
                    //    UserName = "test1",
                    //    Name = "TESTA TEST",
                    //    BirthDate = DateTime.UtcNow
                    //};

                    //await userManager.CreateAsync(authorUser, "123456");

                    //await userManager.AddToRoleAsync(authorUser, authorName);

                    //authorUser = new User
                    //{
                    //    Email = "test2@mail.bg",
                    //    UserName = "test2",
                    //    Name = "TESTA POPO",
                    //    BirthDate = DateTime.UtcNow
                    //};

                    //await userManager.CreateAsync(authorUser, "123456");

                    //await userManager.AddToRoleAsync(authorUser, authorName);

                    //var trainerUser = new User
                    //{
                    //    Email = "trainer@mail.bg",
                    //    UserName = "Some1",
                    //    Name = "Some SOME",
                    //    BirthDate = DateTime.UtcNow
                    //};

                    //await userManager.CreateAsync(trainerUser, "123456");

                    //await userManager.AddToRoleAsync(trainerUser, trainerName);

                    //trainerUser = new User
                    //{
                    //    Email = "trainer2@mail.bg",
                    //    UserName = "Some2",
                    //    Name = "Some SOME2",
                    //    BirthDate = DateTime.UtcNow
                    //};

                    //await userManager.CreateAsync(trainerUser, "123456");

                    //await userManager.AddToRoleAsync(trainerUser, trainerName);
                }).Wait();
            }
            return app;
        }
    }
}
