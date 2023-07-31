using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Data.Configurations;

public class ClothingSIzesEntityConfiguration: IEntityTypeConfiguration<ClothingSizes>
{
    public void Configure(EntityTypeBuilder<ClothingSizes> builder)
    {
        
    }


    private ClothingSizes[] GenerateClothingSizes()
    {

        ICollection<ClothingSizes> clothingSizes = new HashSet<ClothingSizes>();

        ClothingSizes size;

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            Size = ClothesSizes.L,
            SizeQuantity = 40
        };

        clothingSizes.Add(size);

    }
}