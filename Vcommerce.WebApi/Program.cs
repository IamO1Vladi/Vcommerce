using BlogRepository.Interfaces;
using ClothingRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data;
using Vcommerce.Services.ProductServices;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.Infrastructures.Extensions;

namespace Vcommerce.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Add services to the container.
            builder.Services.AddDbContext<VcommerceDbContext>(opt =>
            {
                opt.UseSqlServer(connectionString);
            });

            builder.Services.AddScoped<IClothingService, ClothingService>();
            builder.Services.AddApplicationRepositoryServices(typeof(IClothingRepo));
            builder.Services.AddApplicationRepositoryServices(typeof(IBlogRepo));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(setup =>
            {
                setup.AddPolicy("AllowVcommerApp", policyBuilder =>
                {
                    //policyBuilder.WithOrigins("https://localhost:7088")
                    //    .AllowAnyHeader()
                    //    .AllowAnyMethod();

                    policyBuilder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });

                setup.AddDefaultPolicy(policyBuilder =>
                {
                    policyBuilder.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });

            });
         

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.UseCors();

            app.UseRouting();

            app.Run();
        }
    }
}