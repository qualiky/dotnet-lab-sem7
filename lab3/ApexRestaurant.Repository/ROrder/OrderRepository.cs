using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.RStaff;

public class OrderRepository: GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}