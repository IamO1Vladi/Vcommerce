using Microsoft.AspNetCore.Mvc;
using Vcommerce.Data.Models.Enums;

namespace Vcommerce.Web.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Products(Category category , Gender gender)
        {

            return View();
        }

    }
}
