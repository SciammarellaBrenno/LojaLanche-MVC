using CursoUdemy.Context;
using CursoUdemy.Models;
using CursoUdemy.Repository.Interface;
using CursoUdemy.Repository.Repositories.Shared;

namespace CursoUdemy.Repository.Repositories;

public class LancheRepository : MasterRepository<Lanche>, ILancheRepository
{
    public LancheRepository(CursoUdemyContext context) : base(context)
    {

    }
}
