using CursoUdemy.Models;
using CursoUdemy.Models.Shared;

namespace CursoUdemy.Repository.Interface.Shared;

public interface IMasterRepository<TEntity> where TEntity : class, IEntity
{
    IQueryable<TEntity> GetAll();
    TEntity GetById(long id);
}
