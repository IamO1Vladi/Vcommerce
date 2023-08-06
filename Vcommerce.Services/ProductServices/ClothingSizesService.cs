using Vcommerce.Data;
using Vcommerce.Data.Models;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.ClothingSizes;

namespace Vcommerce.Services.ProductServices;

public class ClothingSizesService:IClothingSizesService
{
    private readonly VcommerceDbContext dbContext;
    private readonly IClothingService clothingService;

    public ClothingSizesService(VcommerceDbContext context,IClothingService clothingService)
    {
        this.dbContext = context;
        this.clothingService = clothingService;
    }

    public async Task AddSizesForClothing(ClothingSizesViewModel[] model)
    {

        ICollection<ClothingSizes> clothingSizes = new HashSet<ClothingSizes>();

        ClothingSizes newSize;

        foreach (var size in model)
        {
            newSize = new ClothingSizes()
            {
                ClothingId = size.ClothingId,
                Size = size.Size,
                SizeQuantity = size.SizeQuantity,
            };

            clothingSizes.Add(newSize);

        }

        await dbContext.ClothingSizes.AddRangeAsync(clothingSizes);
        await dbContext.SaveChangesAsync();

        await clothingService.UpdateClothingQuantity(model.First().ClothingId,
            clothingSizes.Sum(cs => cs.SizeQuantity));
    }
}