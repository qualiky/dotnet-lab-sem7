using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RCustomer;

namespace ApexRestaurant.Services.SCustomer;

public class CustomerService: GenericService<Customer>, ICustomerService
{
	ICustomerRepository iCustomerRepository;
	public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
	{
		this.iCustomerRepository = customerRepository;
	}

	
}


