using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vcommerce.Data.Models;

namespace Vcommerce.Data.Configurations;

public class ClothesEntityConfiguration :IEntityTypeConfiguration<Clothes>
{
    public void Configure(EntityTypeBuilder<Clothes> builder)
    {
        builder.Property(c => c.Price)
            .HasPrecision(18, 2);

        builder.Property(c=>c.SalePercentage)
            .HasPrecision(18, 2);

    }
}