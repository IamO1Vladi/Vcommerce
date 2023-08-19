using ClothingRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;

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

    public async Task<ClothingSizes> GetSizeAsync(Guid clothingId, ClothesSizes size)
    {
        var currentSize = await dbContext.ClothingSizes.Where(cs => cs.ClothingId == clothingId && cs.Size == size).FirstAsync();

        return currentSize;
    }

    public async Task ReduceQuantity(Guid sizeId,int quantity)
    {

        var size = await dbContext.ClothingSizes.FindAsync(sizeId);

        size.SizeQuantity-=quantity;

        await dbContext.SaveChangesAsync();

    }
}