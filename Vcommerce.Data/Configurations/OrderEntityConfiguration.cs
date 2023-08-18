using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vcommerce.Data.Models.Order;

namespace Vcommerce.Data.Configurations;

public class OrderEntityConfiguration:IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
       builder.Property(b=>b.ClothesTotalPrice)
           .HasPrecision(18, 2);

       builder.Property(b=>b.ShippingPrice)
           .HasPrecision(18, 2);

       builder.Property(b=>b.TotalPrice)
           .HasPrecision(18, 2);
    }
}