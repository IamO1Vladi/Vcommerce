using Microsoft.AspNetCore.Mvc;
using Vcommerce.Services.BrandServices.Interfaces;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Brands;
using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Web.Controllers
{
    public class BrandController : Controller
    {

        private readonly IBrandService brandService;
        private readonly IClothingService clothingService;

        public BrandController(IBrandService service,IClothingService clothingService)
        {
            this.brandService = service;
            this.clothingService = clothingService;
        }

        [HttpGet]
        public IActionResult Add()
        {


            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddOrEditBrandViewModel model)
        {

            await brandService.AddBrandAsync(model);

            return RedirectToAction("BrandsList", "Brand");
        }

        [HttpGet]

        public async Task<IActionResult> BrandsList()
        {

            ListAllBrandsViewModel[] brands = await brandService.GetAllBrandsListAsync();


            return View(brands);
        }

        [HttpGet]

        public async Task<IActionResult> Edit(Guid brandId)
        {

            var model = await brandService.GetBrandViewModelAsync(brandId);

            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Guid brandId,AddOrEditBrandViewModel model)
        {

            await brandService.EditBrandAsync(model, brandId);

            return RedirectToAction("BrandsList", "Brand");
        }

        [HttpGet]

        public async Task<IActionResult> Delete(Guid brandId)
        {

            var clothesToDelete = await clothingService.GetClotheDeleteViewModelsByBrandIdAsync(brandId);

            ViewData["brandId"] = brandId;

            return View(clothesToDelete);
        }


        [HttpPost]

        public async Task<IActionResult> DeleteBrand(Guid brandId)
        {

            await clothingService.DeleteAllClothesByBrandId(brandId);

            await brandService.DeleteBrandAsync(brandId);

            return RedirectToAction("BrandsList", "Brand");
        }
    }
}
