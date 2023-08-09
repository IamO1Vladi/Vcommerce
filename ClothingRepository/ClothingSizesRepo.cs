using ClothingRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data;
using Vcommerce.Data.Models;

namespace ClothingRepository;

public class ClothingSizesRepo:IClothingSizesRepo
{
    private readonly VcommerceDbContext dbContext;

    public ClothingSizesRepo(VcommerceDbContext context)
    {
        this.dbContext = context;
    }

    public async Task<ClothingSizes[]> GetSizesAsync(Guid clothingId)
    {
        var sizes = await dbContext.ClothingSizes.Where(cs => cs.ClothingId.Equals(clothingId)).ToArrayAsync();

        return sizes;
    }
}