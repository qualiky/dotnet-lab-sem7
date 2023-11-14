using System;

namespace ApexRestaurant.Repository.Domain;

public class Staff {
    public int id { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Address { get; set; }
    public String PhoneRes { get; set; }
    public String PhoneMob { get; set; }
    public DateTime EnrollDate { get; set; }
    public int StaffRole {get; set;}
    public int DirectManager {get; set;}
} 