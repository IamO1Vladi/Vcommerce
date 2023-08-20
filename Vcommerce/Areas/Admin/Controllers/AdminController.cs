using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static Vcommerce.Areas.Admin.AdminConstants;

namespace Vcommerce.Web.Areas.Admin.Controllers

{

    [Area(AriaName)]
    [Authorize(Roles = AdminRoleName)]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
