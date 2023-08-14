using ClothingRepository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;

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
        public async Task<IActionResult> ProductsByCategoryAndGender(Category category , Gender gender)
        {

            var products = await clothingService.GetClothesForShoppingList(gender, category);
            
            return View(products);
        }

        [HttpGet]

        public async Task<IActionResult> ProductDetails(Guid productId)
        {

            var productDetails = await clothingService.GetClothingDetails(productId);
            

            return View(productDetails);
        }

        [HttpGet]

        public async Task<IActionResult> ProductsByGender(Gender gender)
        {
            var products = await clothingService.GetClothesForShoppingListByGender(gender);
           


            return View(products);

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
    }
}
