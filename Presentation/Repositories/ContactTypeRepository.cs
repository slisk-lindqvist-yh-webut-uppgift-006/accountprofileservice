using Presentation.Data;
using Presentation.Data.Entities;

namespace Presentation.Repositories;

public interface IContactTypeRepository
{
}

public class ContactTypeRepository(DataContext context) 
    : BaseRepository<ContactTypeEntity>(context), IContactTypeRepository
{
    
}

