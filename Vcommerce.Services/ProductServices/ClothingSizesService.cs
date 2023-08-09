using ClothingRepository.Interfaces;
using Vcommerce.Data;
using Vcommerce.Data.Models;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.ClothingSizes;

namespace Vcommerce.Services.ProductServices;

public class ClothingSizesService:IClothingSizesService
{
    private readonly VcommerceDbContext dbContext;
    private readonly IClothingService clothingService;
    private readonly IClothingSizesRepo clothingSizesRepo;

    public ClothingSizesService(VcommerceDbContext context,IClothingService clothingService, IClothingSizesRepo clothingSizesRepo)
    {
        this.dbContext = context;
        this.clothingService = clothingService;
        this.clothingSizesRepo = clothingSizesRepo;
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

    public async Task<ClothingSizesViewModel[]> GetClothingSizesViewModel(Guid clothingId)
    {
        ICollection<ClothingSizesViewModel> clothingSizes = new HashSet<ClothingSizesViewModel>();

        var sizes = await clothingSizesRepo.GetSizesAsync(clothingId);

        sizes = sizes.OrderBy(s => s.Size).ToArray();
        ClothingSizesViewModel clothingSize;

        foreach (var size in sizes)
        {

            clothingSize = new ClothingSizesViewModel()
            {
                ClothingId = clothingId,
                Size = size.Size,
                SizeQuantity = size.SizeQuantity
            };

            clothingSizes.Add(clothingSize);

        }

        return clothingSizes.ToArray();
    }

    public async Task EditSizesForClothing(ClothingSizesViewModel[] model)
    {
        var clothingSizes = await clothingSizesRepo.GetSizesAsync(model.First().ClothingId);

        clothingSizes = clothingSizes.OrderBy(cs => cs.Size).ToArray();

        for (int i = 0; i < model.Length; i++)
        {
            clothingSizes[i].SizeQuantity = model[i].SizeQuantity;
        }

        await dbContext.SaveChangesAsync();
    }
}