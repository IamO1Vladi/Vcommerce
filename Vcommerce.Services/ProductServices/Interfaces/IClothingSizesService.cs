using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.ServiceModels.Product;
using Vcommerce.Web.ViewModels.ClothingSizes;

namespace Vcommerce.Services.ProductServices.Interfaces;

public interface IClothingSizesService
{
    public Task AddSizesForClothing(ClothingSizesViewModel[] model);

    public Task<ClothingSizesViewModel[]> GetClothingSizesViewModel(Guid clothingId);

    public Task EditSizesForClothing(ClothingSizesViewModel[] model);

    public Task<ClothingSizeServiceModel[]> GetAvailableClothingSizesByIdAsync(Guid clothingId);
}