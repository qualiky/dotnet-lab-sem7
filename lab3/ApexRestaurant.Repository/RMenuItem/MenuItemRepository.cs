using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.RMenuItem;

public class MenuItemRepository: GenericRepository<MenuItem>, IMenuItemRepository
{
    public MenuItemRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}