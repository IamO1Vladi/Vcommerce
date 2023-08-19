using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Vcommerce.Models;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;

namespace Vcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClothingService clothingService;

        public HomeController(ILogger<HomeController> logger,IClothingService clothingService) 
        {
            _logger = logger;
            this.clothingService = clothingService;
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}