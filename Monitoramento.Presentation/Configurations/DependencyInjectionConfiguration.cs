using MonitoramentoAPI.Application.Contracts;
using MonitoramentoAPI.Application.Services;
using MonitoramentoAPI.Domain.Contracts.Data;
using MonitoramentoAPI.Domain.Contracts.Services;
using MonitoramentoAPI.Domain.Services;
using MonitoramentoAPI.Infra.Repositories;

namespace MonitoramentoAPI.Presentation.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            #region Application Layer 

            services.AddTransient<IFuncionarioApplicationService, FuncionarioApplicationService>();

            #endregion

            #region Domain Layer 

            services.AddTransient<IFuncionarioDomainService, FuncionarioDomainService>();
            services.AddTransient<IRastreamentoDomainService, RastreamentoDomainService>();

            #endregion

            #region InfraStructure Layer 

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #endregion
        }
    }
}