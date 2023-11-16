using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RStaffRole;

namespace ApexRestaurant.Services.SStaffRole;

public class StaffRoleService : GenericService<StaffRole>, IStaffRoleService
{
    public StaffRoleService(IStaffRoleRepository staffRoleRepository) : base(staffRoleRepository)
    {
        
    }
}


