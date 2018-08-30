namespace SocialMedia
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using SocialMedia.Data.Data;
    using SocialMedia.Data.Models;
    using SocialMedia.Infrastructure.Extensions;
    using SocialMedia.Services;
    using SocialMedia.Services.Admin.Implementations;
    using SocialMedia.Services.Admin.Interfaces;
    using SocialMedia.Services.Common.Implementations;
    using SocialMedia.Services.Common.Interfaces;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SocialMediaDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<SocialMediaDbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc(options =>
            {
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
            });

            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<ISearchService, SearchService>();
            services.AddTransient<IAlbumService, AlbumService>();
            services.AddTransient<IPictureService, PictureService>();
            services.AddTransient<IHomeService, HomeService>();
            services.AddTransient<ICommentService, CommentService>();
            services.AddTransient<IManageService, ManageService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient<IFollowerService, FollowerService>();

            services.AddMvc();
            //services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapperProfile)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDatabaseMigrations();

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
