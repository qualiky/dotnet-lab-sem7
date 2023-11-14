using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository.RStaff;

public class ReservationRepository: GenericRepository<Reservation>, IReservationRepository
{
    public ReservationRepository(RestaurantContext dbContext) {
        DbContext = dbContext;
    }
}