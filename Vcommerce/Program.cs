using BlogRepository.Interfaces;
using ClothingRepository;
using ClothingRepository.Interfaces;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Vcommerce.Data;
using Vcommerce.Data.Models.Users;
using Vcommerce.Services.ApiServices.FireBaseApiService;
using Vcommerce.Services.ApiServices.FireBaseApiService.Interfaces;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.Infrastructures.Extensions;
using Vcommerce.Web.Infrastructures.ModelBinders;


namespace Vcommerce
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<VcommerceDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount =
                        builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                    options.Password.RequireLowercase = 
                        builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                    options.Password.RequireUppercase = 
                        builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                    options.Password.RequireNonAlphanumeric = 
                        builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                    options.Password.RequireDigit =
                        builder.Configuration.GetValue<bool>("Identity:Password:RequireDigit");
                    options.Password.RequiredLength =
                        builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
                })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<VcommerceDbContext>();


          
            Environment.SetEnvironmentVariable("bucket", "craftdemo-78c02.appspot.com");

            //Adding DI for Google Credentials
            var credentials = builder.Configuration.GetSection("FireBaseCredentials").GetChildren();
            
            builder.Services.AddSingleton<IFireBaseGoogleCredential>(new FireBaseGoogleCredential(credentials));

            builder.Services.AddApplicationServices(typeof(IClothingService));
            builder.Services.AddApplicationRepositoryServices(typeof(IClothingRepo));
            builder.Services.AddApplicationRepositoryServices(typeof(IBlogRepo));
            //builder.Services.AddScoped<IClothingRepo, ClothingRepo>(); //Delete later an implement correctly 

            builder.Services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/User/Login";
                cfg.AccessDeniedPath = "/User/Login";
            });

            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                // Set a short timeout for easy testing
                options.IdleTimeout = TimeSpan.FromDays(7);
                // XSS security
                options.Cookie.HttpOnly = true;
            });

            builder.Services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/User/Login";
                cfg.AccessDeniedPath = "/Home/Error/401";
            });

            builder.Services.AddControllersWithViews()
                .AddMvcOptions(options =>
                {
                    options.ModelBinderProviders.Insert(0,new DecimalModelBinderProvider());
                    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
                });

          
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();


            // UseSession() Middleware must be called before UseMvc()
            app.UseSession();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.SeedAdministrator();

            app.UseEndpoints(config =>
            {

                config.MapControllerRoute(
                    name: "areas",
                    pattern: "/{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                config.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                config.MapRazorPages();

            });


           

            await app.RunAsync();
        }
    }
}