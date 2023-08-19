using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Vcommerce.Models;
using Vcommerce.Services.ApiServices.QuickBaseApiService.Interfaces;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Services.ServiceModels.Email;
using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClothingService clothingService;
        private readonly IQuickBaseService quickBaseService;

        public HomeController(ILogger<HomeController> logger,IClothingService clothingService,IQuickBaseService quickBaseService) 
        {
            _logger = logger;
            this.clothingService = clothingService;
            this.quickBaseService = quickBaseService;
        }

        [AllowAnonymous]
        
        public async Task<IActionResult> Index()
        {

            var exclusiveClothes = await clothingService.GetAllExclusiveProducts();

            return View(exclusiveClothes);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ExclusiveProducts(string tag)
        {

            switch (tag)
            {
                case "Sale":
                    var products = await clothingService.GetExclusiveProductsForSpecialOffer();
                    return PartialView("PartialViews/_ExclusiveProdcutsList", products);
                    
            }
            return PartialView("PartialViews/_ExclusiveProdcutsList");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ContactUs()
        {

            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SendQuestions(GetInTouchServiceModel model)
        {

            await quickBaseService.SendMessage(model);

           return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SaveSubscription(string email)
        {

            await quickBaseService.SaveToSubscriptions(email);

            return Json(new { success = true, redirectToUrl = "successfully." });
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}