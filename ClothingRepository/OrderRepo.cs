using ClothingRepository.Interfaces;
using Vcommerce.Data;
using Vcommerce.Data.Models.JoinTableModels;
using Vcommerce.Data.Models.Order;

namespace ClothingRepository;

public class OrderRepo:IOrderRepo
{

    private readonly VcommerceDbContext dbContext;

    public OrderRepo(VcommerceDbContext context)
    {
        this.dbContext = context;
    }

    public async Task AddRangeAsync(OrderedClothing[] newOrder)
    {
       await dbContext.OrderedClothing.AddRangeAsync(newOrder);

       await dbContext.SaveChangesAsync();
    }

    public async Task AddNewOrder(Order order)
    {
        await dbContext.Orders.AddAsync(order);

        await dbContext.SaveChangesAsync();
    }
}