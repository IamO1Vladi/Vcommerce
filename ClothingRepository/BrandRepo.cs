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
}