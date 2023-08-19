using Vcommerce.Web.ViewModels.Clothes;
using Vcommerce.Web.ViewModels.Orders;

namespace Vcommerce.Services.OrderServices.Interfaces;

public interface IOrderService
{
    
    public Task AddNewOrderAsync(NewOrderViewModel  model,ClothingForLayoutCartViewModel[] clothesJson);

}