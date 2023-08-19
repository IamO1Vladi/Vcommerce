using ClothingRepository.Interfaces;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Data.Models.JoinTableModels;
using Vcommerce.Data.Models.Order;
using Vcommerce.Services.OrderServices.Interfaces;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;
using Vcommerce.Web.ViewModels.Orders;

namespace Vcommerce.Services.OrderServices;

public class OrderService:IOrderService
{
    private readonly IClothingService clothingService;
    private readonly IOrderRepo orderRepo;
   

    public OrderService(IClothingService service,IOrderRepo repo)
    {
        this.clothingService = service;
        this.orderRepo = repo;
       
    }

    public async Task AddNewOrderAsync(NewOrderViewModel model,ClothingForLayoutCartViewModel[] clothesToAdd)
    {

       

        Order order = new Order
        {
            Country = model.Country,
            City = model.City,
            Street = model.Street,
            PostalCode = model.PostalCode,
            ClothesTotalPrice = clothesToAdd.Sum(c=>c.Price*c.Quantity) ,
            ShippingPrice = 0,
            TotalPrice = clothesToAdd.Sum(c => c.Price * c.Quantity),
            Email = model.Email,
            PhoneNumber = model.PhoneNumber,
            PaymentType = model.PaymentType,
            UserId = model.UserId,
        };

        await orderRepo.AddNewOrder(order);

        ICollection<OrderedClothing> clothesToOrder= new HashSet<OrderedClothing>();

        OrderedClothing newClothing;

        foreach (var clothing in clothesToAdd)
        {

            ClothesSizes size = (ClothesSizes)Enum.Parse(typeof(ClothesSizes), clothing.Size.ToUpper());

            newClothing = new OrderedClothing
            {
                Quantity = clothing.Quantity,
                Status = OrderStatus.Unapproved,
                Size =size,
                ClothingId = clothing.ClothingId,
                OrderId = order.Id,

            };

            clothesToOrder.Add(newClothing);

            await clothingService.ReduceQuantity(clothing.ClothingId, clothing.Quantity,size);

        }

        await orderRepo.AddRangeAsync(clothesToOrder.ToArray());



    }
}