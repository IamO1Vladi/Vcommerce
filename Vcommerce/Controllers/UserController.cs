using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vcommerce.Data.Models.Users;

namespace Vcommerce.Web.Controllers
{
    public class UserController : Controller
    {

        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }



        public IActionResult Login()
        {

            return View();
        }

    }
}
