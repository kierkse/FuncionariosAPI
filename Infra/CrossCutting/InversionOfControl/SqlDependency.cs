using FuncionariosAPI.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FuncionariosAPI.Infra.CrossCutting.InversionOfControl
{
    public static class SqlDependency
    {
        public static void AddSqlDependency(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<SqlContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}