using BeeProdicts.Areas.Identity.Data;
using BeeProdicts.Data;
using BeeProdicts.Helpers;
using BeeProdicts.Interface;
using BeeProdicts.Models;
using BeeProdicts.Repository;
using BeeProdicts.Service;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BeeProdicts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("BeeProdictsDbContextConnection") ?? throw new InvalidOperationException("Connection string 'BeeProdictsDbContextConnection' not found.");

            builder.Services.AddDbContext<BeeProdictsDbContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<BeeProdictsDbContext>();

            //builder.Services.AddScoped<IProduct, ProductFromBeeRepository>();
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IBlog, BlogPostsRepository>();
            builder.Services.AddScoped<IProduct, ProductRepository>();
          
           
            builder.Services.AddScoped<IPhotoService,PhotoService>();
          

            builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddRazorPages();

            builder.Services.Configure<IdentityOptions>(option =>
            {
                option.Password.RequireUppercase = false;
            });

            var app = builder.Build();

            if (args.Length == 1 && args[0].ToLower() == "seeddata")
            {

                Seed.SeedData(app);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}