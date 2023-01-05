using CursoUdemy.Context;
using CursoUdemy.Models.Shared;
using CursoUdemy.Repository.Interface.Shared;

namespace CursoUdemy.Repository.Repositories.Shared;

public class MasterRepository<TEntity> : IMasterRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly CursoUdemyContext _context;
    protected IQueryable<TEntity> _query;

    public MasterRepository(CursoUdemyContext context)
    {
        _context = context;
        _query = _context.Set<TEntity>();
    }

    public IQueryable<TEntity> GetAll()
    {
        return _query;
    }

    public TEntity GetById(long id)
    {
        return _query.SingleOrDefault(x => x.Id.Equals(id));
    }
}
