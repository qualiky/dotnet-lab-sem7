using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.ROrderItem;

public class OrderItemRepository: GenericRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}