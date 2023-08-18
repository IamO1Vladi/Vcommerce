using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data.Configurations;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Blog;
using Vcommerce.Data.Models.BrandInfo;
using Vcommerce.Data.Models.Collections;
using Vcommerce.Data.Models.JoinTableModels;
using Vcommerce.Data.Models.Order;
using Vcommerce.Data.Models.Shops;
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

        public DbSet<ClothingImages> ClothesImages { get; set; } = null!;

        public DbSet<ClothingSizes> ClothingSizes { get; set; } = null!;

        public DbSet<Review> ClothingReviews { get; set; } = null!;

        public DbSet<BlogPost> BlogPosts { get; set; } = null!;

        public DbSet<Comment> PostComments { get; set; } = null!;

        public DbSet<Brand> Brands { get; set; }=null!;

        public DbSet<Collection> Collections { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<OrderedClothing> OrderedClothing { get; set; } = null!;

        public DbSet<Shop> Shops { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(ClothesEntityConfiguration)) ?? Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(configAssembly);
            base.OnModelCreating(builder);
        }
    }
}