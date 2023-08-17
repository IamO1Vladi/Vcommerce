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
using Vcommerce.Data.Models.Users;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;
using Vcommerce.Web.ViewModels.Reviews;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Formatters;
using Vcommerce.Services.ServiceModels.Product;
using Vcommerce.Web.Infrastructures.Extensions;
using Vcommerce.Web.ViewModels.Clothes.Enums;
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
                BrandId = viewModel.Brand,
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
               Brand = clothing.BrandId,
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

            currentClothing.BrandId = model.Brand;
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

        public async Task<DeleteClothesByBranViewModel[]> GetClotheDeleteViewModelsByBrandIdAsync(Guid brandId)
        {
            var clothes = await clothingRepo.GetClothesByBrandIdAsync(brandId);

            ICollection<DeleteClothesByBranViewModel> clothesToDelete = new HashSet<DeleteClothesByBranViewModel>();

            DeleteClothesByBranViewModel viewModel;

            foreach (var clothe in clothes)
            {
                viewModel = new DeleteClothesByBranViewModel
                {
                    Id = clothe.Id,
                    Name = clothe.Name,
                    ImageUrl = clothe.Images.Count > 0
                        ? clothe.Images.First().ImageUrl
                        : "/assets/images/product_img2.jpg",
                    Price = clothe.Price,
                };
                clothesToDelete.Add(viewModel);
            }

            return clothesToDelete.ToArray();
        }

        public async Task DeleteAllClothesByBrandId(Guid brandId)
        {
            await clothingRepo.DeleteAllClothesFromABrandAsync(brandId);
        }

        public async Task<ReviewViewModelForList[]> GetClothingReviewsByIdAsync(Guid clothingId)
        {
            ICollection<ReviewViewModelForList> reviewViewModel = new List<ReviewViewModelForList>();

            Review[] reviews = await context.ClothingReviews.Where(r => r.RelatedClothingIdGuid == clothingId).Include(r=>r.UserPosted)
                .OrderByDescending(r => r.DatePosted).ToArrayAsync();

            ReviewViewModelForList viewModel;

            foreach (var review in reviews)
            {
                viewModel = new ReviewViewModelForList
                {
                    Description = review.Description,
                    ClothingId = review.RelatedClothingIdGuid,
                    Rating = review.Rating,
                    DateCreated = review.DatePosted,
                    AvatarUrl = "/assets/images/user2.jpg", // fix later
                    Name = review.UserPosted.UserName,
                    ReviewId = review.Id
                };

                reviewViewModel.Add(viewModel);
            }


            return reviewViewModel.ToArray();
        }

        public async Task<Guid> AddClothingReview(Guid clothingId, AddReviewViewModel review)
        {
            var clothing = await context.Clothes.FindAsync(clothingId);

            

            Review newReview = new Review
            {
                UserPostedId = review.UserPosted,
                DatePosted = DateTime.UtcNow,
                Rating = review.Rating,
                Description = review.Description,
                RelatedClothingIdGuid = review.ClothingId
            };

            await context.ClothingReviews.AddAsync(newReview);
            await context.SaveChangesAsync();

            return newReview.Id;
        }

        public async Task<ReviewViewModelForList> GetClothingReviewByIdAsync(Guid reviewId)
        {
            var review = await context.ClothingReviews.Include(r => r.UserPosted).FirstAsync(r => r.Id == reviewId);

            ReviewViewModelForList viewModel = new ReviewViewModelForList
            {
                Description = review.Description,
                ClothingId = review.RelatedClothingIdGuid,
                Rating = review.Rating,
                DateCreated = review.DatePosted,
                AvatarUrl = "/assets/images/user2.jpg", // fux later
                Name = review.UserPosted.UserName,
                ReviewId = reviewId
            };


            return viewModel;
        }

        public async Task DeleteReviewByIdAsync(Guid reviewId)
        {
            Review? review = await context.ClothingReviews.FindAsync(reviewId);

            context.ClothingReviews.Remove(review);

            await context.SaveChangesAsync();
        }

        public async Task<ClothesFilteredAndPagedServiceModel> GetClothesFilteredAndPagedServiceModelAsync(ClothesQueryModel queryModel,Gender gender, Category? category=Category.NoCategory )
        {
            IQueryable<Clothes> clothes;

            if (category == Category.NoCategory)
            {
                clothes =
                    context.Clothes.Where(c => c.Gender == gender).Include(c => c.Brand).Include(c => c.Reviews);

            }
            else
            {
                clothes =
                    context.Clothes.Where(c => c.Gender == gender && c.Category == category).Include(c => c.Brand).Include(c => c.Reviews);

            }


            if (!string.IsNullOrWhiteSpace(queryModel.Brand))
            {
                clothes = clothes.Where(c => c.Brand.Name == queryModel.Brand);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.SearchString))
            {
                string wildCard = $"%{queryModel.SearchString.ToLower()}%";
                clothes = clothes.Where(c => EF.Functions.Like(c.Name, wildCard) ||
                                             EF.Functions.Like(c.Description, wildCard));
            }

            clothes = queryModel.ClothesSorting switch
            {
                ClothesSorting.Newest => clothes.OrderByDescending(c => c.DateCreated),
                ClothesSorting.Oldest => clothes.OrderBy(c => c.DateCreated),
                ClothesSorting.Default => clothes.OrderBy(c => c.Name),
                ClothesSorting.PriceAscending => clothes.OrderBy(c =>
                    c.IsOnSale ? c.Price - (c.Price * (c.SalePercentage / 100)) : c.Price),
                ClothesSorting.PriceDescending => clothes.OrderByDescending(c =>
                    c.IsOnSale ? c.Price - (c.Price * (c.SalePercentage / 100)) : c.Price),
                ClothesSorting.Popularity => clothes.OrderBy(c => c.Reviews.Average(c => c.Rating)),
                _ => clothes.OrderBy(c=>c.Name)
            };


            IEnumerable<ShopListClothingViewModel> shoppingListClothes = await clothes
                .Skip((queryModel.CurrentPage - 1) * queryModel.ClothesPerPage).Take(queryModel.ClothesPerPage)
                .Select(c => new ShopListClothingViewModel
                {
                    ClothingId = c.Id,
                    Name = c.Name,
                    Price = c.Price,
                    SalesPercentage = c.SalePercentage,
                    IsOnSale = c.IsOnSale,
                    IsNew = c.DateCreated >= DateTime.UtcNow.AddDays(-14) ? true : false,
                    IsHot = c.NumberOfSales >= NumberOfSalesRequiredToBeHot,
                    Color = c.Color,
                    Description = c.Description,
                    Category = c.Category,
                    Gender = c.Gender,
                    Brand = c.Brand
                }).ToArrayAsync();

            foreach (var clothing in shoppingListClothes)
            {
                clothing.ImageUrls = await clothingRepo.GetImageUrlsForAProductById(clothing.ClothingId);
            }

            int totalClothes = clothes.Count();

            return new ClothesFilteredAndPagedServiceModel()
            {
                TotalClothesCount = totalClothes,
                Clothes = shoppingListClothes
            };
        }
    }
}
