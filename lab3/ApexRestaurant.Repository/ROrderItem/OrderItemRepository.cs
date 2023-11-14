using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.RStaff;

public class OrderItemRepository: GenericRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}