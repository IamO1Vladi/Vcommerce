using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.ServiceModels.Product;
using Vcommerce.Web.ViewModels.Clothes;
using Vcommerce.Web.ViewModels.Reviews;

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

    public Task<ReviewViewModelForList[]> GetClothingReviewsByIdAsync(Guid clothingId);

    public Task<Guid> AddClothingReview(Guid clothingId, AddReviewViewModel review);

    public Task<ReviewViewModelForList> GetClothingReviewByIdAsync(Guid reviewId);

    public Task DeleteReviewByIdAsync(Guid reviewId);

    public Task<ClothesFilteredAndPagedServiceModel> GetClothesFilteredAndPagedServiceModelAsync(ClothesQueryModel queryModel, Gender gender, Category? category = Category.TShirts);


    public Task<ReviewInfoServiceModel> GetReviewInfoByIdAsync(Guid clothingId);


    public Task<ClothingForLayoutCartViewModel[]> GetClothingForLayoutCartAsync(string cardItemsJson);
}