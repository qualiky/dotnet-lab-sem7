using ApexRestaurant.Services.SCustomer;
using ApexRestaurant.Services.SMenuItem;
using ApexRestaurant.Services.SOrder;
// using ApexRestaurant.Services.SOrderItem;
using ApexRestaurant.Services.SReservation;
using ApexRestaurant.Services.SStaff;
using ApexRestaurant.Services.SStaffRole;
using ApexRestaurant.Services.STable;
using Microsoft.Extensions.DependencyInjection;

namespace ApexRestaurant.Services;

public static class ServiceModule
{
	public static void Register(IServiceCollection services)
	{
		services.AddTransient<ICustomerService, CustomerService>();
		services.AddTransient<IMenuItemService, MenuItemService>();
		services.AddTransient<IOrderService, OrderService>();
		//services.AddTransient<IOrderItemService, OrderItemService>();
		services.AddTransient<IReservationService, ReservationService>();
		services.AddTransient<IStaffService, StaffService>();
		services.AddTransient<IStaffRoleService, StaffRoleService>();
		services.AddTransient<ITableService, TableService>();
	}
}


