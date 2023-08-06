using FirebaseAdmin.Auth.Multitenancy;
using Microsoft.AspNetCore.Mvc;
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

            return RedirectToAction("Index","Home");
        }
    }
}
