using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RStaff;


namespace ApexRestaurant.Services.SReservation;

public class ReservationService : GenericService<Reservation>, IReservationService
{
    public ReservationService(IReservationRepository reservationRepository) : base(reservationRepository)
    {
        
    }
}


