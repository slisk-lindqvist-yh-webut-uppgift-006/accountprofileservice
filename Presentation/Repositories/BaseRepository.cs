using Microsoft.EntityFrameworkCore;
using Presentation.Data;

namespace Presentation.Repositories;

public interface IBaseRepository
{
}

public abstract class BaseRepository<TEntity> : IBaseRepository where TEntity : class
{
    protected readonly DataContext _context;
    protected readonly DbSet<TEntity> _table;

    protected BaseRepository(DataContext context)
    {
        _context = context;
        _table = _context.Set<TEntity>();
    }
}