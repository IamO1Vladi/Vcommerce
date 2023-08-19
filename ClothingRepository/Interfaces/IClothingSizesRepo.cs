using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;

namespace ClothingRepository.Interfaces;

public interface IClothingSizesRepo
{
 
    public Task<ClothingSizes[]> GetSizesAsync(Guid clothingId);

    public Task<ClothingSizes> GetSizeAsync(Guid clothingId, ClothesSizes size);

    public Task ReduceQuantity(Guid sizeId,int quantity);
}