using Presentation.Data;
using Presentation.Data.Entities;

namespace Presentation.Repositories;

public interface IAddressInfoRepository
{
}

public class AddressInfoRepository(DataContext context) 
    : BaseRepository<AddressInfoEntity>(context), IAddressInfoRepository
{
    
}