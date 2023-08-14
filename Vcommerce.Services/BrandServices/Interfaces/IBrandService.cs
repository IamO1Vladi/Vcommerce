using Vcommerce.Web.ViewModels.Brands;

namespace Vcommerce.Services.BrandServices.Interfaces;

public interface IBrandService
{
    
    public Task AddBrandAsync(AddOrEditBrandViewModel  viewModel);

    public Task<ListAllBrandsViewModel[]> GetAllBrandsListAsync();

}