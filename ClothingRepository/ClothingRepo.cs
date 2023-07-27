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
            var clothes = await dbContext.Clothes.Where(c => c.Category == category && c.Gender == gender).ToArrayAsync();

            return clothes;
        }

        public async Task<string[]> GetImageUrlsForAProductById(Guid id)
        {
            var imageUrls = await dbContext.ClothesImages.Where(ci => ci.ClothingGuid == id)
                .Select(ci => ci.ImageUrl)
                .ToArrayAsync();

            return imageUrls;
        }
    }
}
