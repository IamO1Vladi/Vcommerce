using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Data.Configurations;

public class ClothingSIzesEntityConfiguration: IEntityTypeConfiguration<ClothingSizes>
{
    public void Configure(EntityTypeBuilder<ClothingSizes> builder)
    {
        builder.HasData(GenerateClothingSizes());
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

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            Size = ClothesSizes.M,
            SizeQuantity = 40
        };

        clothingSizes.Add(size);

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            Size = ClothesSizes.S,
            SizeQuantity = 40
        };

        clothingSizes.Add(size);

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            Size = ClothesSizes.XS,
            SizeQuantity = 40
        };

        clothingSizes.Add(size);

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            Size = ClothesSizes.XXL,
            SizeQuantity = 40
        };

        clothingSizes.Add(size);
        
        //----------

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("9F984CB7-39A8-4003-B9F2-B27ECD32842F"),
            Size = ClothesSizes.L,
            SizeQuantity = 40
        };

        clothingSizes.Add(size);

        
        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("9F984CB7-39A8-4003-B9F2-B27ECD32842F"),
            Size = ClothesSizes.M,
            SizeQuantity = 20
        };
        clothingSizes.Add(size);

        
        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("9F984CB7-39A8-4003-B9F2-B27ECD32842F"),
            Size = ClothesSizes.XL,
            SizeQuantity = 15
        };
        clothingSizes.Add(size);

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("9F984CB7-39A8-4003-B9F2-B27ECD32842F"),
            Size = ClothesSizes.S,
            SizeQuantity = 30
        };
        clothingSizes.Add(size);

        //-------------

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("0BBB0CE2-68F3-4CB1-B3A6-DE68C6AD1FCD"),
            Size = ClothesSizes.S,
            SizeQuantity = 30
        };
        clothingSizes.Add(size);

       size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("0BBB0CE2-68F3-4CB1-B3A6-DE68C6AD1FCD"),
            Size = ClothesSizes.M,
            SizeQuantity = 25
        };
        clothingSizes.Add(size);

         size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("0BBB0CE2-68F3-4CB1-B3A6-DE68C6AD1FCD"),
            Size = ClothesSizes.L,
            SizeQuantity = 35
        };
        clothingSizes.Add(size);

         size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("0BBB0CE2-68F3-4CB1-B3A6-DE68C6AD1FCD"),
            Size = ClothesSizes.XL,
            SizeQuantity = 20
        };
        clothingSizes.Add(size);


        //-------------

        size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("47B74821-1DD5-4AAC-868A-AED6661017F6"),
            Size = ClothesSizes.XL,
            SizeQuantity = 20
        };
        clothingSizes.Add(size);

         size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("47B74821-1DD5-4AAC-868A-AED6661017F6"),
            Size = ClothesSizes.S,
            SizeQuantity = 10
        };
        clothingSizes.Add(size);

         size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("47B74821-1DD5-4AAC-868A-AED6661017F6"),
            Size = ClothesSizes.M,
            SizeQuantity = 15
        };
        clothingSizes.Add(size);

         size = new ClothingSizes()
        {
            ClothingId = Guid.Parse("47B74821-1DD5-4AAC-868A-AED6661017F6"),
            Size = ClothesSizes.XXL,
            SizeQuantity = 25
        };
        clothingSizes.Add(size);


        return clothingSizes.ToArray();
    }
}