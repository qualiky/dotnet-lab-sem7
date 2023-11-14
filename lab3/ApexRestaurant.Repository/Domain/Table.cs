using System;

namespace ApexRestaurant.Repository.Domain;

public class Table {
    public int Id { get; set; }
    public int Capacity { get; set; }
    public String Status { get; set; }
}