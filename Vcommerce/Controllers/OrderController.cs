using Microsoft.AspNetCore.Mvc;

namespace Vcommerce.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
