using FirebaseAdmin.Auth.Multitenancy;
using Microsoft.AspNetCore.Mvc;
using Vcommerce.Data.Models;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.ClothingSizes;

namespace Vcommerce.Web.Controllers
{
    public class ClothingSizesController : Controller
    {

        private readonly IClothingSizesService clothingSizesService;

        public ClothingSizesController(IClothingSizesService service)
        {
            this.clothingSizesService = service;
        }

        [HttpGet]
        public IActionResult AddProductSizes(Guid productId)
        {
            ViewData["productId"]= productId;
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddProductSizes(ClothingSizesViewModel[] sizes)
        {


            await clothingSizesService.AddSizesForClothing(sizes);

            return RedirectToAction("ProductDetails","Product", new { productId =sizes.First().ClothingId});
        }

        [HttpGet]
        public async Task<IActionResult> EditProductSizes(Guid productId)
        {
            ViewData["productId"]=productId;

            var sizes = await clothingSizesService.GetClothingSizesViewModel(productId);

            return RedirectToAction("ProductDetails", "Product", new { productId = sizes.First().ClothingId });
        }

        [HttpPost]
        public async Task<IActionResult> EditProductSizes(ClothingSizesViewModel[] sizes)
        {

            await clothingSizesService.EditSizesForClothing(sizes);

            return RedirectToAction("Index","Home");
        }

        
    }
}
