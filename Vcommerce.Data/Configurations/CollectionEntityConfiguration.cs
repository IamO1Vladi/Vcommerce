using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Collections;

namespace Vcommerce.Data.Configurations;

public class CollectionEntityConfiguration:IEntityTypeConfiguration<Collection>
{
    public void Configure(EntityTypeBuilder<Collection> builder)
    {

        builder.HasMany(col => col.Clothes)
            .WithOne(c => c.Collection)
            .HasForeignKey(c => c.CollectionId)
            .OnDelete(DeleteBehavior.Restrict);

    }
}