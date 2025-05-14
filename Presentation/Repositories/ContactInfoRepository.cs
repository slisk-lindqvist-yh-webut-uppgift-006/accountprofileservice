using Presentation.Data;
using Presentation.Data.Entities;

namespace Presentation.Repositories;

public interface IContactInfoRepository
{
}

public class ContactInfoRepository(DataContext context) 
    : BaseRepository<ContactInfoEntity>(context), IContactInfoRepository
{
    
}

