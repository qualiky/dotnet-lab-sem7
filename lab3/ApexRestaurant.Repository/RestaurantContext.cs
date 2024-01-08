using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository;

public class RestaurantContext: DbContext 
{
    public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options) {

    }

    public DbSet<Customer> Customers { get; set;}
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<StaffRole> StaffRoles { get; set; }
    public DbSet<MenuItem> MenuItems { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}