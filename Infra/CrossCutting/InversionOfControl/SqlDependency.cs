using FuncionariosAPI.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace FuncionariosAPI.Infra.CrossCutting.InversionOfControl
{
    public static class SqlDependency
    {
        public static void AddSqlDependency(this IServiceCollection service)
        {
            service.AddDbContext<SqlContext>();
        }
    }
}