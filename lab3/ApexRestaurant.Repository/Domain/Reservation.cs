using System;

namespace ApexRestaurant.Repository.Domain;

public class Reservation
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime ReservationDate { get; set;}
    public int TableNumber { get; set; }
    public int PartySize { get; set; }
}