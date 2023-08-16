using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Vcommerce.Data;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;

using static VCommerce.Common.ClothesFilters.ClothesFiltersConstants;

namespace ClothingRepository
{
    public class ClothingRepo:IClothingRepo
    {
        private VcommerceDbContext dbContext;

        public ClothingRepo(VcommerceDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Category[]> GetAvailableCategories(Gender g)
        {
            var avaiableCategories = await dbContext.Clothes
                .Where(c=>c.Gender==g)
                .Select(c => c.Category)
                .Distinct()
                .ToArrayAsync();

            return avaiableCategories;
        }

        public async Task<Clothes[]> GetAllClothesByCategoryAndGender(Gender gender, Category category)
        {
            var clothes = await dbContext.Clothes.Where(c => c.Category == category && c.Gender == gender).Include(b=>b.Brand).ToArrayAsync();

            return clothes;
        }

        public async Task<string[]> GetImageUrlsForAProductById(Guid id)
        {
            var imageUrls = await dbContext.ClothesImages.Where(ci => ci.ClothingGuid == id)
                .Select(ci => ci.ImageUrl)
                .ToArrayAsync();

            return imageUrls;
        }

        public async Task<Clothes> GetClothingById(Guid id)
        {

            var clothing = await dbContext.Clothes.FindAsync(id);

            if (clothing == null)
            {
                throw new ArgumentNullException("Add message later");
            }

            return clothing;
        }

        public async Task<Clothes[]> GetClothesByGender(Gender gender)
        {
            var clothing = await dbContext.Clothes.Where(c=>c.Gender==gender).Include(b=>b.Brand).Include(c=>c.Images).ToArrayAsync();

            return clothing;
        }

        public async Task<Clothes[]> GetClothesOnSale()
        {
            var clothes = await dbContext.Clothes.Where(c => c.IsOnSale == true).ToArrayAsync();

            return clothes;
        }

        public async Task<Clothes[]> GetNewClothes()
        {
            var clothes = await dbContext.Clothes.Where(c => c.DateCreated >= DateTime.UtcNow.AddDays(-14)).ToArrayAsync();
            
            return clothes;
        }

        public async Task<Clothes[]> GetAllClothes()
        {
            var clothes = await dbContext.Clothes.ToArrayAsync();

            return clothes;
        }

        public async Task<Clothes[]> GetHotClothes()
        {
            var clothes = await dbContext.Clothes.Where(c => c.NumberOfSales >= NumberOfSalesRequiredToBeHot).OrderBy(c=>c.NumberOfSales)
                .ToArrayAsync();

            return clothes;
        }

        public async Task<Clothes[]> GetClothesByBrandIdAsync(Guid brandId)
        {
            var clothes = await dbContext.Clothes.Where(c => c.BrandId == brandId).Include(c=>c.Images).ToArrayAsync();

            return clothes;
        }

        public async Task DeleteAllClothesFromABrandAsync(Guid brandId)
        {

            var clothesToRemove = await this.GetClothesByBrandIdAsync(brandId);

            if (clothesToRemove.Length>0)
            {
                dbContext.Clothes.RemoveRange(clothesToRemove);

                await dbContext.SaveChangesAsync();

            }


        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}
