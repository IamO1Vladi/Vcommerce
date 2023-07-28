using System.ComponentModel;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Services.ProductServices.Interfaces;

public interface IClothingService
{
    public Task<ShopListClothingViewModel[]> GetClothesForShoppingList(Gender  gender, Category category);

    public Task<ClothingDetailsViewModel> GetClothingDetails(Guid id);
}