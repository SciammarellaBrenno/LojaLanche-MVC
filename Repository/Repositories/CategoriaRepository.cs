using CursoUdemy.Context;
using CursoUdemy.Models;
using CursoUdemy.Repository.Interface;
using CursoUdemy.Repository.Repositories.Shared;

namespace CursoUdemy.Repository.Repositories;

public class CategoriaRepository : MasterRepository<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(CursoUdemyContext context) : base(context)
    {

    }
}
