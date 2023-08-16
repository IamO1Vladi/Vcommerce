using ClothingRepository.Interfaces;
using Vcommerce.Data.Models.BrandInfo;
using Vcommerce.Services.ApiServices.FireBaseApiService.Interfaces;
using Vcommerce.Services.BrandServices.Interfaces;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Brands;

namespace Vcommerce.Services.BrandServices;

public class BrandService:IBrandService
{

    private readonly IBrandRepo brandRepo;
    private readonly IImagesService clothingImagesService;
    private readonly IClothingService clothingClothingService;

    public BrandService(IBrandRepo repo,IImagesService clothingImagesService, IClothingService clothingClothingService)
    {
        this.brandRepo = repo;
        this.clothingImagesService = clothingImagesService;
        this.clothingClothingService = clothingClothingService;
    }
    public async Task AddBrandAsync(AddOrEditBrandViewModel viewModel)
    {
        Brand newBrand = new Brand
        {
            Name = viewModel.Name,
            Description = viewModel.Description,
        };

        if (viewModel.Image != null)
        {
            string imageUrl= await clothingImagesService.AddBrandImage(viewModel.Image);

            newBrand.LogoUrl = imageUrl;
        }
         

        await brandRepo.AddBrandAsync(newBrand);

    }

    public async Task<ListAllBrandsViewModel[]> GetAllBrandsListAsync()
    {
        ICollection<ListAllBrandsViewModel> brandsViewModel = new HashSet<ListAllBrandsViewModel>();

        Brand[] brands= await brandRepo.GetAllBrandsAsync();

        ListAllBrandsViewModel viewModelBrand;

        foreach (var brand in brands)
        {
            viewModelBrand = new ListAllBrandsViewModel
            {
                Name = brand.Name,
                BrandId = brand.Id,
                Description = brand.Description,
                LogoUrl = brand.LogoUrl,
            };
            brandsViewModel.Add(viewModelBrand);
        }

        return brandsViewModel.ToArray();
    }

    public async Task EditBrandAsync(AddOrEditBrandViewModel viewModel, Guid brandId)
    {
        var brand = await brandRepo.GetBrandByIdAsync(brandId);

        brand.Name = viewModel.Name;
        brand.Description = viewModel.Description;
        if (viewModel.Image != null)
        {
            string imageUrl = await clothingImagesService.AddBrandImage(viewModel.Image);
            brand.LogoUrl = imageUrl;
        }

        await brandRepo.SaveChangesToDbAsync();

    }

    public async Task<AddOrEditBrandViewModel> GetBrandViewModelAsync(Guid brandId)
    {
        var brand = await brandRepo.GetBrandByIdAsync(brandId);

        AddOrEditBrandViewModel brandViewModel = new AddOrEditBrandViewModel
        {
            Name = brand.Name,
            Description = brand.Description,
        };

        return brandViewModel;
    }



    public async Task DeleteBrandAsync(Guid brandId)
    {

        var brand = await brandRepo.GetBrandByIdAsync(brandId);

        await brandRepo.DeleteBrandAsync(brand);

    }
}