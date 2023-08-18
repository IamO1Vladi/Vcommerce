using ClothingRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Vcommerce.Data.Models;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Services.ServiceModels.Filtering;
using Vcommerce.Services.ServiceModels.Product;
using Vcommerce.Web.ViewModels.Clothes;
using Vcommerce.Web.ViewModels.Reviews;

namespace Vcommerce.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBrandRepo brandRepo;


        private readonly IClothingService clothingService;
        private readonly IImagesService clothingImagesService;

        public ProductController(IClothingService clothingService,IImagesService clothingImagesService,IBrandRepo brandRepo)
        {
            this.brandRepo = brandRepo;

            this.clothingService = clothingService;
            this.clothingImagesService = clothingImagesService;

        }

        [HttpGet]
        public async Task<IActionResult> ProductsByCategoryAndGender([FromQuery] ClothesQueryModel queryModel)
        {

            ClothesFilteredAndPagedServiceModel products =
                await clothingService.GetClothesFilteredAndPagedServiceModelAsync(queryModel, queryModel.Gender, queryModel.Category);

            queryModel.TotalClothes = products.TotalClothesCount;
            queryModel.Clothes=products.Clothes;
            queryModel.Brands=products.Clothes.Select(c=>c.Brand.Name).ToList();
            
            return View(queryModel);
        }

        [HttpGet]

        public async Task<IActionResult> ProductDetails(Guid productId)
        {

            var productDetails = await clothingService.GetClothingDetails(productId);
            

            return View(productDetails);
        }

        [HttpGet]

        public async Task<IActionResult> ProductsByGender([FromQuery] ClothesQueryModel queryModel)
        {
            ClothesFilteredAndPagedServiceModel products =
                await clothingService.GetClothesFilteredAndPagedServiceModelAsync(queryModel, queryModel.Gender, queryModel.Category);

            queryModel.TotalClothes = products.TotalClothesCount;
            queryModel.Clothes = products.Clothes;
            queryModel.Brands = products.Clothes.Select(c => c.Brand.Name).ToList();

            return View(queryModel);

        }

        [HttpGet]

        public async Task<IActionResult> Add()
        {
            ViewData["Brands"] = await brandRepo.GetAllBrandsAsync();
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddOrEditClothingViewModel model)
        {

            var productId=await clothingService.AddClothing(model);
            await clothingImagesService.AddClothingImages(model.Images,productId);


            return RedirectToAction("AddProductSizes", "ClothingSizes",new {productId=productId});
        }

        [HttpDelete]

        public async Task<IActionResult> Delete(Guid productId)
        {
            await clothingService.DeleteClothing(productId);

            return Json(new { success = true, redirectToUrl = "Item deleted successfully." });
        }


        [HttpGet]

        public async Task<IActionResult> Edit(Guid productId)
        {
            ViewData["Brands"] = await brandRepo.GetAllBrandsAsync();
            var clothing = await clothingService.GetClothingViewModelById(productId);

            return View(clothing);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Guid productId,AddOrEditClothingViewModel model)
        {
         
            await clothingService.EditClothing(productId,model);

            return RedirectToAction("EditProductSizes", "ClothingSizes", new {productId=productId});
        }


        [HttpPost]

        public async Task<IActionResult> SubmitReview([FromBody] AddReviewViewModel review)
        {
            if (ModelState.IsValid)
            {

              Guid reviewId= await clothingService.AddClothingReview(review.ClothingId, review);

              var reviewModel = await clothingService.GetClothingReviewByIdAsync(reviewId);

              return PartialView("PartialViews/_ClothingReviewsPartialView", reviewModel);
            }

            return BadRequest(ModelState);
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteReview(Guid reviewId)
        {

            await clothingService.DeleteReviewByIdAsync(reviewId);

            return Ok(new { message = "Review deleted successfully" });
        }


       


        //[HttpPost]
        //public async  Task<IActionResult> GetFilteredClothes([FromBody] ShopListFilteringServiceModel model)
        //{

        //    var clothing = await clothingService.GetClothesForShoppingList(model.Gender, model.Category);

        //    ICollection<ShopListClothingViewModel> filteredClothing = new List<ShopListClothingViewModel>();

            

        //    foreach (var guid in model.BrandId)
        //    {
        //        foreach (var clothingItem in clothing)
        //        {
        //            if (clothingItem.Brand.Id == Guid.Parse(guid))
        //            {
        //                filteredClothing.Add(clothingItem);
        //            }
        //        }
        //    }

        //    if (model.BrandId.Any())
        //    {
        //        return PartialView("PartialViews/_ProductsList", filteredClothing.ToArray());
        //    }

        //    return PartialView("PartialViews/_ProductsList", clothing);

        //}
    }
}
