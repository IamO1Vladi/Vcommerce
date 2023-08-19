using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vcommerce.Services.OrderServices.Interfaces;
using Vcommerce.Services.ProductServices;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;
using Vcommerce.Web.ViewModels.Orders;

namespace Vcommerce.Web.Controllers
{
    public class OrderController : Controller
    {

        private readonly IClothingService clothingService;
        private readonly IOrderService orderService;

        public OrderController(IClothingService service,IOrderService orderService)
        {
            this.clothingService = service;
            this.orderService = orderService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ShoppingCart()
        {

            string? cartItemsJson = this.HttpContext.Session.GetString("cartItems");

            if (string.IsNullOrWhiteSpace(cartItemsJson))
            {
                cartItemsJson = "";
            }

            var clothingItems = await clothingService.GetClothingForLayoutCartAsync(cartItemsJson);

            return View(clothingItems);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> LoadOrderInfo()
        {
            string? cartItemsJson = this.HttpContext.Session.GetString("cartItems");

            if (string.IsNullOrWhiteSpace(cartItemsJson))
            {
                cartItemsJson = "";
            }

            var clothingItems = await clothingService.GetClothingForLayoutCartAsync(cartItemsJson);


            return PartialView("PartialViews/_OrderPartialView", clothingItems);
        }
       
        

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Checkout(NewOrderViewModel newOrder)
        {

            string? cartItemsJson = this.HttpContext.Session.GetString("cartItems");
            var clothingItems = await clothingService.GetClothingForLayoutCartAsync(cartItemsJson);

            await orderService.AddNewOrderAsync(newOrder, clothingItems);

            this.HttpContext.Session.Clear();

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Checkout()
        {

            return View();
        }
    }
}
