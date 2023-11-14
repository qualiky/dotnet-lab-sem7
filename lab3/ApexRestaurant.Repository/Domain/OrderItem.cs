using System;

namespace ApexRestaurant.Repository.Domain;

public class OrderItem 
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public double SubTotal { get; set; }
}