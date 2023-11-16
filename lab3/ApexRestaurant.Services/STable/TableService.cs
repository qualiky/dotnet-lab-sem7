using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository.RStaffRole;

namespace ApexRestaurant.Services.STable;

public class TableService : GenericService<Table>, ITableService
{
    public TableService(ITableRepository tableRepository) : base(tableRepository)
    {
        
    }
}


