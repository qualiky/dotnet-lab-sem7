using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.ROrderItem;

namespace ApexRestaurant.Services.SOrderItem;

public class OrderItemService : GenericService<OrderItem>, IOrderItemService
{
    public OrderItemService(OrderItemRepository orderItemRepository) : base(orderItemRepository)
    {
        
    }
}


