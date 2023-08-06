using Vcommerce.Web.ViewModels.ClothingSizes;

namespace Vcommerce.Services.ProductServices.Interfaces;

public interface IClothingSizesService
{
    public Task AddSizesForClothing(ClothingSizesViewModel[] model);
}