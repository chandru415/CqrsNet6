using Api.Installers.Interfaces;
using Application;
using Infrastructure;

namespace Api.Installers.InstallServices
{
    public class DIInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddControllers();
            services.AddApplication();
            services.AddInfrastructure();
        }
    }
}
