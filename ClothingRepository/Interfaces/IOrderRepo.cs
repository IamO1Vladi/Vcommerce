using Vcommerce.Data.Models.JoinTableModels;
using Vcommerce.Data.Models.Order;

namespace ClothingRepository.Interfaces;

public interface IOrderRepo
{

    public Task AddRangeAsync(OrderedClothing[] newOrder);

    public Task AddNewOrder(Order order);

}