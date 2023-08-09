using Vcommerce.Data.Models;

namespace ClothingRepository.Interfaces;

public interface IClothingSizesRepo
{
 
    public Task<ClothingSizes[]> GetSizesAsync(Guid clothingId);

}