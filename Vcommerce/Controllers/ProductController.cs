using Microsoft.AspNetCore.Mvc;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Web.Controllers
{
    public class ProductController : Controller
    {

        private IClothingService clothingService;

        public ProductController(IClothingService clothingService)
        {
            
            this.clothingService = clothingService;

        }

        [HttpGet]
        public async Task<IActionResult> ProductsByCategoryAndGender(Category category , Gender gender)
        {

            var products = await clothingService.GetClothesForShoppingList(gender, category);
            
            return View(products);
        }

        [HttpGet]

        public async Task<IActionResult> ProductDetails(Guid productId,Category category,Gender gender)
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

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddOrEditClothingViewModel model)
        {

            return RedirectToAction("AddProductSizes", "ClothingSizes");
        }

    }
}
