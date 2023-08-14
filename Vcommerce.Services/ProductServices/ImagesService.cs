using Microsoft.AspNetCore.Http;
using Vcommerce.Data;
using Vcommerce.Data.Models;
using Vcommerce.Services.ApiServices.FireBaseApiService.Interfaces;
using Vcommerce.Services.ProductServices.Interfaces;

namespace Vcommerce.Services.ProductServices;

public class ImagesService:IImagesService
{
    private readonly IFireBaseApiService fireBaApiService;
    private readonly VcommerceDbContext dbContext;

    public ImagesService(IFireBaseApiService service,VcommerceDbContext context)
    {
        this.fireBaApiService=service;
        this.dbContext=context;
    }

    public async Task AddClothingImages(ICollection<IFormFile> images, Guid clothingId)
    {
        ICollection<ClothingImages> clothingImages = new HashSet<ClothingImages>();

           

        foreach (var image in images)
        {
            
            if (image.Length > 0)
            {
                using (var stream = image.OpenReadStream())
                {
                    Guid imageName = Guid.NewGuid();
                    string imageUrl = await fireBaApiService.UploadImageToFireBase(stream, imageName.ToString(),
                        Environment.GetEnvironmentVariable("bucket")!);

                    ClothingImages newImage = new ClothingImages()
                    {
                        ClothingGuid = clothingId,
                        Id = imageName,
                        ImageUrl = imageUrl
                    };

                    clothingImages.Add(newImage);

                }
            }

        }
        await dbContext.ClothesImages.AddRangeAsync(clothingImages);
        await dbContext.SaveChangesAsync();


    }

    public async Task<string> AddBrandImage(IFormFile image, Guid brandId)
    {
        if (image.Length > 0)
        {
            using (var stream = image.OpenReadStream())
            {
                Guid imageName=Guid.NewGuid();
                string imageUrl = await fireBaApiService.UploadImageToFireBase(stream, imageName.ToString(),
                    Environment.GetEnvironmentVariable("bucket")!);

                return imageUrl;
            }

            
           
        }

        return "NoImage";
    }
}