using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data.Models;

namespace Vcommerce.Data
{
    public class VcommerceDbContext : IdentityDbContext
    {
        public VcommerceDbContext(DbContextOptions<VcommerceDbContext> options)
            : base(options)
        {

        }

        public DbSet<Clothes> Clothes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}