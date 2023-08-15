using Vcommerce.Data.Models.BrandInfo;

namespace ClothingRepository.Interfaces;

public interface IBrandRepo
{

    public Task<Brand[]> GetAllBrandsAsync();

    public Task AddBrandAsync(Brand brand);

    public Task SaveChangesToDbAsync();

    public Task DeleteBrandAsync(Brand brand);

    public Task<Brand> GetBrandByIdAsync(Guid id);
}