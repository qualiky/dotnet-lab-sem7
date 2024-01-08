using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RReservation;

namespace ApexRestaurant.Services.SReservation;

public class ReservationService : GenericService<Reservation>, IReservationService
{
    public ReservationService(IReservationRepository reservationRepository) : base(reservationRepository)
    {
        
    }
}


