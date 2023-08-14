using Microsoft.AspNetCore.Mvc;
using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Web.Controllers
{
    public class BrandController : Controller
    {

        [HttpGet]
        public IActionResult Add()
        {


            return View();
        }

        [HttpPost]

        public Task<IActionResult> Add(AddOrEditClothingViewModel model)
        {

            return View();
        }
    }
}
