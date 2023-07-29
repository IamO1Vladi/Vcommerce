using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;

namespace ClothingRepository.Interfaces;

public interface IClothingRepo
{

    public Task<Category[]> GetAvailableCategories(Gender gender);

    public Task<Clothes[]> GetAllClothesByCategoryAndGender(Gender gender,Category category);

    public Task<string[]> GetImageUrlsForAProductById(Guid  id);

    public Task<Clothes> GetClothingById(Guid id);

    public Task<Clothes[]> GetClothesByGender(Gender gender);

    public Task<Clothes[]> GetClothesOnSale();

    public Task<Clothes[]> GetNewClothes();

    public Task<Clothes[]> GetAllClothes();

    public Task<Clothes[]> GetHotClothes();
}