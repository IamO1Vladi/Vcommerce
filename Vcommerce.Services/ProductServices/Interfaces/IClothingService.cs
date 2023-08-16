using System.ComponentModel;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Services.ProductServices.Interfaces;

public interface IClothingService
{
    public Task<ShopListClothingViewModel[]> GetClothesForShoppingList(Gender  gender, Category category);

    public Task<ClothingDetailsViewModel> GetClothingDetails(Guid id);

    public Task<ShopListClothingViewModel[]> GetClothesForShoppingListByGender(Gender gender);

    public Task<ExclusiveProductsViewModel[]> GetExclusiveProductsForSpecialOffer();

    public Task<ExclusiveProductsViewModel[]> GetExclusiveProductsForNewArrivals();

    public Task<ExclusiveProductsViewModel[]> GetExclusiveProductsForBestSellers();

    public Task<AllExclusiveProductsForHomePageVIewModel> GetAllExclusiveProducts();

    public Task<Guid> AddClothing(AddOrEditClothingViewModel viewModel);

    public Task UpdateClothingQuantity(Guid clothingId,int quantity);

    public Task DeleteClothing(Guid clothingId);

    public Task<AddOrEditClothingViewModel> GetClothingViewModelById(Guid id);

    public Task EditClothing(Guid id,AddOrEditClothingViewModel model);

    public Task<DeleteClothesByBranViewModel[]> GetClotheDeleteViewModelsByBrandIdAsync(Guid brandId);

    public Task DeleteAllClothesByBrandId(Guid brandId);

    
}