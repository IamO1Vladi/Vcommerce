using ClothingRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data;
using Vcommerce.Data.Models.BrandInfo;

namespace ClothingRepository;

public class BrandRepo:IBrandRepo
{

    private readonly VcommerceDbContext dbContext;

    public BrandRepo(VcommerceDbContext context)
    {
        this.dbContext = context;
    }

    public async Task<Brand[]> GetAllBrandsAsync()
    {
        var brands = await dbContext.Brands.ToArrayAsync();

        return brands;
    }

    public async Task AddBrandAsync(Brand brand)
    {
        await dbContext.AddAsync(brand);
        await dbContext.SaveChangesAsync();
    }

    public async Task SaveChangesToDbAsync()
    {
        await dbContext.SaveChangesAsync();
    }


    public async Task DeleteBrandAsync(Brand brand)
    {
        throw new NotImplementedException();
    }

    public async Task<Brand> GetBrandByIdAsync(Guid id)
    {
        Brand? brand = await dbContext.Brands.FindAsync(id);

        if (brand == null)
        {
            throw new ArgumentNullException();
        }
        
        return brand;
    }
}