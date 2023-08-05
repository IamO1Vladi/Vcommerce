using Microsoft.AspNetCore.Http;
using Vcommerce.Data.Models;

namespace Vcommerce.Services.ProductServices.Interfaces;

public interface IClothingImagesService
{

    public Task AddClothingImages(ICollection<IFormFile> images,Guid clothingId);

}