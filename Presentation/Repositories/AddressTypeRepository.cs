using Presentation.Data;

namespace Presentation.Repositories;

public interface IAddressTypeRepository
{
}

public class AddressTypeRepository(DataContext context) 
    : BaseRepository<AddressTypeEntity>(context), IAddressTypeRepository
{
    
}

