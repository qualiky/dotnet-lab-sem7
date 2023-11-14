using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.RStaffRole;

public class StaffRoleRepository: GenericRepository<StaffRole>, IStaffRoleRepository
{
    public StaffRoleRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}