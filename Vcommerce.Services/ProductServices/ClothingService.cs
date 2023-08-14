using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingRepository.Interfaces;
using Vcommerce.Data;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;

using static VCommerce.Common.ClothesFilters.ClothesFiltersConstants;

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
                IsNew = c.DateCreated >= DateTime.UtcNow.AddDays(-14) ? true : false,
                IsOnSale = c.IsOnSale,
                IsHot = c.NumberOfSales>=NumberOfSalesRequiredToBeHot,
                Name = c.Name,
                Price = c.Price,
                SalesPercentage = c.SalePercentage,
                Category = c.Category,
                Gender = c.Gender,
                Brand = c.Brand
            })
                .ToArray();

            foreach (var clothing in clothesViewModel)
            {
                clothing.ImageUrls = await clothingRepo.GetImageUrlsForAProductById(clothing.ClothingId);
            }

            return clothesViewModel;
        }

        public async Task<ClothingDetailsViewModel> GetClothingDetails(Guid id)
        {
            
            var dbClothing= await clothingRepo.GetClothingById(id);

            var images = await clothingRepo.GetImageUrlsForAProductById(id);

            var clothingDetails = new ClothingDetailsViewModel()
            {
                ClothingId = dbClothing.Id,
                Color = dbClothing.Color,
                Description = dbClothing.Description,
                IsNew = dbClothing.DateCreated >= DateTime.UtcNow.AddDays(-14) ? true : false,
                IsOnSale = dbClothing.IsOnSale,
                Name = dbClothing.Name,
                Price = dbClothing.Price,
                Material = dbClothing.Material,
                SalesPercentage = dbClothing.SalePercentage,
                ImageUrls = images,
                Category = dbClothing.Category,
                Gender = dbClothing.Gender
            };

            return clothingDetails;
        }

        public async Task<ShopListClothingViewModel[]> GetClothesForShoppingListByGender(Gender gender)
        {
            var clothes = await clothingRepo.GetClothesByGender(gender);

            var clothesViewModel = clothes.Select(c => new ShopListClothingViewModel()
                {
                    ClothingId = c.Id,
                    Color = c.Color,
                    Description = c.Description,
                    IsNew = c.DateCreated>=DateTime.UtcNow.AddDays(-14)?true:false,
                    IsOnSale = c.IsOnSale,
                    IsHot = c.NumberOfSales >= NumberOfSalesRequiredToBeHot,
                    Name = c.Name,
                    Price = c.Price,
                    SalesPercentage = c.SalePercentage,
                    Category = c.Category,
                    Gender = c.Gender,
                    Brand = c.Brand
                })
                .ToArray();

            foreach (var clothing in clothesViewModel)
            {
                clothing.ImageUrls = await clothingRepo.GetImageUrlsForAProductById(clothing.ClothingId);
            }

            return clothesViewModel;
        }

        public async Task<ExclusiveProductsViewModel[]> GetExclusiveProductsForSpecialOffer()
        {
            var clothes = await clothingRepo.GetClothesOnSale();

            var exclusiveClothes = clothes.Select(c => new ExclusiveProductsViewModel()
            {
                Color = c.Color,
                Id = c.Id,
                IsNew = c.DateCreated >= DateTime.UtcNow.AddDays(-14) ? true : false,
                IsOnSale = c.IsOnSale,
                Name = c.Name,
                Price = c.Price,
                SalesPercentage = c.SalePercentage,
                Category = c.Category,
                Gender = c.Gender

            }).ToArray();

            foreach (var clothing in exclusiveClothes)
            {
                var images = await clothingRepo.GetImageUrlsForAProductById(clothing.Id);

                if (images.Any())
                {
                    clothing.ImageUrl = images[0];
                }
                else
                {
                    clothing.ImageUrl = "/assets/images/product_img1.jpg";
                }

                
            }

            return exclusiveClothes;
        }

        public async Task<ExclusiveProductsViewModel[]> GetExclusiveProductsForNewArrivals()
        {
            var clothes = await clothingRepo.GetNewClothes();

            var exclusiveClothes = clothes.Select(c => new ExclusiveProductsViewModel()
            {
                Color = c.Color,
                Id = c.Id,
                IsNew = c.DateCreated >= DateTime.UtcNow.AddDays(-14) ? true : false,
                IsOnSale = c.IsOnSale,
                Name = c.Name,
                Price = c.Price,
                SalesPercentage = c.SalePercentage,
                Category = c.Category,
                Gender = c.Gender


            }).ToArray();

            foreach (var clothing in exclusiveClothes)
            {
                var images = await clothingRepo.GetImageUrlsForAProductById(clothing.Id);

                if (images.Any())
                {
                    clothing.ImageUrl = images[0];
                }
                else
                {
                    clothing.ImageUrl = "/assets/images/product_img1.jpg";
                }


            }

            return exclusiveClothes;
        }

        public async Task<ExclusiveProductsViewModel[]> GetExclusiveProductsForBestSellers()
        {
            var clothes = await clothingRepo.GetHotClothes();

            var exclusiveClothes = clothes.Select(c => new ExclusiveProductsViewModel()
            {
                Color = c.Color,
                Id = c.Id,
                IsNew = c.DateCreated >= DateTime.UtcNow.AddDays(-14) ? true : false,
                IsOnSale = c.IsOnSale,
                IsHot = true,
                Name = c.Name,
                Price = c.Price,
                SalesPercentage = c.SalePercentage,
                Category = c.Category,
                Gender = c.Gender

            }).ToArray();

            foreach (var clothing in exclusiveClothes)
            {
                var images = await clothingRepo.GetImageUrlsForAProductById(clothing.Id);

                if (images.Any())
                {
                    clothing.ImageUrl = images[0];
                }
                else
                {
                    clothing.ImageUrl = "/assets/images/product_img1.jpg";
                }


            }

            return exclusiveClothes;
        }

        public async Task<AllExclusiveProductsForHomePageVIewModel> GetAllExclusiveProducts()
        {
            var clothesOnSale = await this.GetExclusiveProductsForSpecialOffer();

            var hotClothes= await this.GetExclusiveProductsForBestSellers();

            var newClothes = await this.GetExclusiveProductsForNewArrivals();

            var exclusiveClothes = new AllExclusiveProductsForHomePageVIewModel()
            {
                HotProducts = hotClothes,
                NewProducts = newClothes,
                ProductsOnSale = clothesOnSale
            };

            return exclusiveClothes;
        }

        public async Task<Guid> AddClothing(AddOrEditClothingViewModel viewModel)
        {

            Clothes newClothing = new Clothes()
            {
                Brand = viewModel.Brand,
                Category = viewModel.Category,
                Color = viewModel.Color,
                Description = viewModel.Description,
                Gender = viewModel.Gender,
                IsOnSale = viewModel.IsOnSale,
                SalePercentage = viewModel.SalePercentage,
                Price = viewModel.Price,
                Name = viewModel.Name,
                Quantity = 0,
                Material = viewModel.Material,
                NumberOfSales = 0
            };

            
            
                await context.Clothes.AddAsync(newClothing);
                await context.SaveChangesAsync();
            

            return newClothing.Id;
        }

        public async Task UpdateClothingQuantity(Guid clothingId,int quantity)
        {
            var clothing = await context.Clothes.FindAsync(clothingId);

            clothing.Quantity=quantity;

            await context.SaveChangesAsync();
        }

        public async Task DeleteClothing(Guid clothingId)
        {
            Clothes clothingToRemove= await context.Clothes.FindAsync(clothingId);
            context.Clothes.Remove(clothingToRemove);

            await context.SaveChangesAsync();
        }

        public async Task<AddOrEditClothingViewModel> GetClothingViewModelById(Guid id)
        {
           var clothing= await clothingRepo.GetClothingById(id);

           AddOrEditClothingViewModel viewModel = new AddOrEditClothingViewModel()
           {
               Brand = clothing.Brand,
               Category = clothing.Category,
               Color = clothing.Color,
               Description = clothing.Description,
               Gender = clothing.Gender,
               IsOnSale = clothing.IsOnSale,
               Material = clothing.Material,
               Name = clothing.Name,
               Price = clothing.Price,
               SalePercentage = clothing.SalePercentage
           };

           return viewModel;
        }

        public async Task EditClothing(Guid id,AddOrEditClothingViewModel model)
        {
            var currentClothing = await clothingRepo.GetClothingById(id);

            currentClothing.Brand = model.Brand;
            currentClothing.Category = model.Category;
            currentClothing.Color = model.Color;
            currentClothing.Description = model.Description;
            currentClothing.Gender = model.Gender;
            currentClothing.IsOnSale = model.IsOnSale;
            currentClothing.Material = model.Material;
            currentClothing.Name = model.Name;
            currentClothing.Price = model.Price;
            currentClothing.SalePercentage = model.SalePercentage;

            await context.SaveChangesAsync();
            
        }
    }
}
