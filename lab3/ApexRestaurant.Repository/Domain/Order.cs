using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApexRestaurant.Repository.Domain;

public class Order 
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public int TableNumber { get; set; }
    public double TotalAmount { get; set; }

}