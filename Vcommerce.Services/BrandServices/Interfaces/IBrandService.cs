using Vcommerce.Web.ViewModels.Brands;

namespace Vcommerce.Services.BrandServices.Interfaces;

public interface IBrandService
{
    
    public Task AddBrandAsync(AddOrEditBrandViewModel  viewModel);

    public Task<ListAllBrandsViewModel[]> GetAllBrandsListAsync();

    public Task EditBrandAsync(AddOrEditBrandViewModel viewModel,Guid brandId);

    public Task<AddOrEditBrandViewModel> GetBrandViewModelAsync(Guid brandId);

    public Task DeleteBrandAsync(Guid brandId);


}