using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Vcommerce.Data.Models;

namespace Vcommerce.Data.Configurations;

public class ClothesImagesEntityConfiguration :IEntityTypeConfiguration<ClothingImages>
{
    public void Configure(EntityTypeBuilder<ClothingImages> builder)
    {
        builder.HasData(GenerateClothingImages());
    }

    private ClothingImages[] GenerateClothingImages()
    {

        ICollection<ClothingImages> clothingImages = new HashSet<ClothingImages>();

        ClothingImages image;

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/male-black-oversized-basketball-graphic-print-t-shirt.jpg?alt=media&token=b6f87596-658f-40e6-82be-6c7d9c2fb0bc"
        };

        clothingImages.Add(image);


        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("283B533B-7ED3-4187-AA7F-CD8A52ED51A5"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/tball-graphic-print-t-shirt.jpg?alt=media&token=0cd8cb68-f961-47e1-ab6a-20bf875c3533"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("94C233FA-0A62-4A3E-9140-F3010EFEDEE2"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/4.jpg?alt=media&token=302976de-afcf-4890-820b-e779a301b097"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("FE367F15-2491-4B35-B956-8B05B7AC7EDA"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/EACHIN-Boys-Pants-Boys-Pants-Solid-Cargo-Pants-Teenage-Boy-Multi-Pocket-Trousers-Kids-Spring-Autumn.jpg?alt=media&token=c893e73d-39e5-4aa5-9d59-7b6dc656d53a"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("4DF2F27B-788A-4EB4-8C1A-30B397D4A1AA"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Untitled.jpg?alt=media&token=3cc125cf-3a85-4cfc-9129-a2ebaf5f4cd4"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("8EC859E8-597E-463B-8A4B-A485D4BE7200"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/lacoste-teen-boys-striped-polo-shirt-386596-2ecde85e16638564ddf8022cb8e3b7e992190f33.jpg?alt=media&token=0c0fbedd-181e-48d0-b37d-50ae7f9fee5f"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("3B86CD7F-C0B6-487F-BE42-A6F61F05B456"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/images.jpg?alt=media&token=b65a904a-0be8-464b-b6df-3f1e3dd24f4a"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("8EC859E8-597E-463B-8A4B-A485D4BE7200"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_de1d201a-9f6a-45c0-a832-c0d0176c03a7.jpg?alt=media&token=51bb66e9-cbaf-45d0-8149-2c473c858d18"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("3B86CD7F-C0B6-487F-BE42-A6F61F05B456"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/Kids'%20Graphic%20Print%20Tee.jpg?alt=media&token=ed6e6aa4-d1fd-463c-aa14-4ebdd3f190ca"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("206BDF4E-8A81-4B28-BCF8-68E9ED167209"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/711CPySZUIL._AC_UY1000_.jpg?alt=media&token=1a95a798-6212-4d38-a2c8-4b3eb04ccf74"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("82BBE618-2B7E-4027-A83A-BFD55D85A3B5"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/GUEST_7c2c7453-493c-4794-8653-7de130c53eb9.jpg?alt=media&token=6f341a35-5fc4-46c9-aab8-8d03a42906c0"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("36E19D2C-825B-431F-9390-5AB3EC07FB2F"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/474305ef653fc6da70213cb4650f37e9.jpg?alt=media&token=f6efc379-f291-4d5e-a330-3f066b96d655"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("FEEC2A48-71CB-4377-93E1-C879D659698C"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A1.jpg?alt=media&token=8125f07a-62e1-40a7-8f25-aec9be4fdfa0"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("1234180A-CAE7-4CF6-B237-A0D443B9C963"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A2.jpg?alt=media&token=b4ad3f80-55ae-4b1f-999b-a4458c8c806f"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("2BA9A727-D0C6-4A41-AE5B-3E8575CE6EF0"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A3.jpg?alt=media&token=097fb988-3822-441f-93af-498f169a8c96"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("6E7438C2-245E-42EF-86DD-43280EEEE071"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A4.jpg?alt=media&token=8a04e1b2-bbc1-4e2f-805f-c0deba5bceb9"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("2D7A7984-DFB6-4C94-AFF4-71047F676F96"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A5.jpg?alt=media&token=875083db-6b93-47c6-a14d-b8c009c7017c"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("902C1A00-502C-40AB-8BBB-5A93D54674A2"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A6.jpg?alt=media&token=a0bc4a08-bf49-4414-929e-aae4ffbe888a"
        };
        clothingImages.Add(image);

        image = new ClothingImages()
        {
            Id = Guid.NewGuid(),
            ClothingGuid = Guid.Parse("32D319E0-C6A4-46B1-82D9-240D7DE9AD2C"),
            ImageUrl = "https://firebasestorage.googleapis.com/v0/b/craftdemo-78c02.appspot.com/o/A7.jpg?alt=media&token=af0ea87a-9947-429f-878e-1c135f2b2132"
        };
        clothingImages.Add(image);



        return clothingImages.ToArray();

    }

}