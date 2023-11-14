using System;

namespace ApexRestaurant.Repository.Domain;

public class MenuItem {
    public int Id { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public double Price { get; set; }
    public String Category { get; set; }

}

