using Microsoft.AspNetCore.Mvc;

namespace Vcommerce.Web.Controllers
{
    public class ClothingSizesController : Controller
    {
        public IActionResult AddProductSizes()
        {
            return View();
        }
    }
}
