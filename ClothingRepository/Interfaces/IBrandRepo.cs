using Vcommerce.Data.Models.BrandInfo;

namespace ClothingRepository.Interfaces;

public interface IBrandRepo
{

    public Task<Brand[]> GetAllBrandsAsync();

}