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

    public BrandService(IBrandRepo repo,IImagesService clothingImagesService)
    {
        this.brandRepo = repo;
        this.clothingImagesService = clothingImagesService;
        
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
            string imageUrl= await clothingImagesService.AddBrandImage(viewModel.Image, newBrand.Id);

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
}