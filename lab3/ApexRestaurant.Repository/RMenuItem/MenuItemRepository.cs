using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.RStaff;

public class MenuItemRepository: GenericRepository<MenuItem>, IMenuItemRepository
{
    public MenuItemRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}