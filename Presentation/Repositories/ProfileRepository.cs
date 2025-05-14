using Presentation.Data;
using Presentation.Data.Entities;

namespace Presentation.Repositories;

public interface IProfileRepository
{
}

public class ProfileRepository(DataContext context) 
    : BaseRepository<ProfileEntity>(context), IProfileRepository
{
    
}

