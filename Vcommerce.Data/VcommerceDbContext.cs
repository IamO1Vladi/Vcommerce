using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data.Configurations;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Users;

namespace Vcommerce.Data
{
    public class VcommerceDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public VcommerceDbContext(DbContextOptions<VcommerceDbContext> options)
            : base(options)
        {

        }

        public DbSet<Clothes> Clothes { get; set; } = null!;

        public DbSet<ProductImages> ProductImages { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(ClothesEntityConfiguration)) ?? Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(configAssembly);
            base.OnModelCreating(builder);
        }
    }
}