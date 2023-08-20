using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vcommerce.Data.Models.Users;
using Vcommerce.Services.UserServices.Interfaces;

namespace Vcommerce.Web.Areas.Admin.Controllers
{
    public class UsersController : AdminController
    {
        private readonly IUserService userService;
        private readonly UserManager<ApplicationUser> userManager;

        public UsersController(IUserService service,UserManager<ApplicationUser> manager)
        {
            this.userService = service;
            this.userManager = manager;
        }

        [Route("User/All")]
        public async Task<IActionResult> All()
        {
            var users = await userService.All();

            return View(users);
        }

       
    }
}
