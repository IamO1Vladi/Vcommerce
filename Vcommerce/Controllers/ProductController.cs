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

            var clothes = await clothingService.GetClothesForShoppingList(gender, category);
            ViewData["Gender"] = gender;
            ViewData["Category"]=category;
            return View(clothes);
        }

        [HttpGet]

        public async Task<IActionResult> ProductDetails(Guid productId,Category category,Gender gender)
        {

            var productDetails = await clothingService.GetClothingDetails(productId);
            ViewData["Gender"] = gender;
            ViewData["Category"] = category;

            return View(productDetails);
        }




    }
}
