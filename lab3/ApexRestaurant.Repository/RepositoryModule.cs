using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApexRestaurant.Repository.RCustomer;
using ApexRestaurant.Repository.RStaff;
using ApexRestaurant.Repository.RStaffRole;
using ApexRestaurant.Repository.RMenuItem;
// using ApexRestaurant.Repository.ROrderItem;
using ApexRestaurant.Repository.ROrder;
using ApexRestaurant.Repository.RReservation;


namespace ApexRestaurant.Repository;

public static class RepositoryModule
{
    public static void Register(IServiceCollection services, string connection) {
        //services.AddDbContext<RestaurantContext>(options => 
        //    options.UseSqlite(connection, builder => 
        //        builder.MigrationsAssembly(migrationsAssembly)
        //    )
        //);
        services.AddDbContext<RestaurantContext>(options =>
            options.UseSqlite(connection)
        );
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<IStaffRepository, StaffRepository>();
        services.AddTransient<IStaffRoleRepository, StaffRoleRepository>();
        services.AddTransient<IMenuItemRepository, MenuItemRepository>();
        services.AddTransient<IOrderRepository, OrderRepository>();
        services.AddTransient<IReservationRepository, ReservationRepository>();
        services.AddTransient<ITableRepository, TableRepository>();
        // services.AddTransient<IOrderItemRepository, OrderItemRepository>();
    }
}