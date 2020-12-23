using Microsoft.Extensions.DependencyInjection;
using FuncionariosAPI.Domain.Interfaces;
using FuncionariosAPI.Services;

namespace FuncionariosAPI.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceFuncionario, FuncionarioService>();
        }
    }
}