using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.ROrder;
using ApexRestaurant.Services.SOrder;

namespace ApexRestaurant.Services.SMenuItem;

public class OrderService : GenericService<Order>, IOrderService
{
    public OrderService(IOrderRepository orderRepository) : base(orderRepository)
    {
        
    }
}


