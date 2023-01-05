using CursoUdemy.Repository.Interface;
using CursoUdemy.Repository.Repositories;

namespace CursoUdemy.Extensions;

public static class ServiceExtension
{
    public static void AddInjections(this IServiceCollection services)
    {
        services.AddTransient<ICategoriaRepository, CategoriaRepository>();
        
        services.AddTransient<ILancheRepository, LancheRepository>();
    }
}
