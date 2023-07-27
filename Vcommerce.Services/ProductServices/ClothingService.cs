using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingRepository.Interfaces;
using Vcommerce.Data;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Services.ProductServices
{
    public class ClothingService:IClothingService
    {
        private VcommerceDbContext context;
        private IClothingRepo clothingRepo;

        public ClothingService(VcommerceDbContext dbContext,IClothingRepo repo)
        {
            this.context=dbContext;
            this.clothingRepo=repo;
        }

        public async Task<ShopListClothingViewModel[]> GetClothesForShoppingList(Gender gender, Category category)
        {
            var clothes = await clothingRepo.GetAllClothesByCategoryAndGender(gender, category);


            var clothesViewModel = clothes.Select(c => new ShopListClothingViewModel()
            {
                ClothingId = c.Id,
                Color = c.Color,
                Description = c.Description,
                IsNew = c.IsNew,
                IsOnSale = c.IsOnSale,
                Name = c.Name,
                Price = c.Price,
                SalesPercentage = c.SalePercentage
            })
                .ToArray();

            foreach (var clothing in clothesViewModel)
            {
                clothing.ImageUrls = await clothingRepo.GetImageUrlsForAProductById(clothing.ClothingId);
            }

            return clothesViewModel;
        }
    }
}
