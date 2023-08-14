using Microsoft.AspNetCore.Http;
using Vcommerce.Data.Models;

namespace Vcommerce.Services.ProductServices.Interfaces;

public interface IImagesService
{

    public Task AddClothingImages(ICollection<IFormFile> images,Guid clothingId);

    public Task<string> AddBrandImage(IFormFile image, Guid brandId);

}