using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vcommerce.Data.Models.Users;
using Vcommerce.Web.ViewModels.Users;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

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

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = new ApplicationUser();
            
           

            await userManager.SetEmailAsync(user, model.Email);
            await userManager.SetUserNameAsync(user, model.UserName);

            IdentityResult result =
                await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await signInManager.SignInAsync(user, false);


            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Login(string? returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginUserFormViewModel model = new LoginUserFormViewModel()
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser? user = await userManager.FindByEmailAsync(model.Email);




            SignInResult result;

            if (user == null)
            {
                return View(model);

            }
            else
            {
                result = await signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe,
                    lockoutOnFailure: false);

               
            }
                

            
            

            if (!result.Succeeded)
            {
                return View(model);
            }

            if (!string.IsNullOrWhiteSpace(model.ReturnUrl))
            {
                return Redirect(model.ReturnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

           
        }
    }

}

