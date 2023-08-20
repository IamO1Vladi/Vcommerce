using Microsoft.AspNetCore.Mvc;

namespace Vcommerce.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminController
    {
        public IActionResult AdminView()
        {
            return View();
        }
    }
}
