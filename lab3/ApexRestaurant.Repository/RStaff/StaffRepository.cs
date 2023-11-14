using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.RStaff;

public class StaffRepository: GenericRepository<Staff>, IStaffRepository
{
    public StaffRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}