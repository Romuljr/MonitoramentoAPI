using Microsoft.Extensions.DependencyInjection;
using MonitoramentoAPI.Application.ViewModels;

namespace MonitoramentoAPI.Presentation.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
