using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RStaff;

namespace ApexRestaurant.Services.SOrderItem;

public class OrderItemService : GenericService<OrderItem>, IOrderItemService
{
    public OrderItemService(IOrderItemRepository orderItemRepository) : base(orderItemRepository)
    {
        
    }
}


