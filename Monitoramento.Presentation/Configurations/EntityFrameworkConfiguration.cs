using Microsoft.EntityFrameworkCore;
using MonitoramentoAPI.Infra.Contexts;

namespace MonitoramentoAPI.Presentation.Configurations
{
    public static class EntityFrameworkConfiguration
    {
        public static void AddEntityFrameworkSetup(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MonitoramentoDB");

            services.AddDbContext<SqlServerContext>
                (options => options.UseSqlServer(connectionString));
        }
    }
}
