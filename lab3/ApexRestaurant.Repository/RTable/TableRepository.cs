using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.RStaffRole;

public class TableRepository: GenericRepository<Table>, ITableRepository
{
    public TableRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}