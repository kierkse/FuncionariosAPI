using FuncionariosAPI.Domain.Interfaces;
using FuncionariosAPI.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FuncionariosAPI.Infra.CrossCutting.InversionOfControl
{
    public static class SqlRepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection service)
        {
            service.AddScoped<IRepositoryFuncionario, FuncionarioRepository>();
        }
    }
}