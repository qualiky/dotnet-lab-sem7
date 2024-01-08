using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.ROrder;

public class OrderRepository: GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}