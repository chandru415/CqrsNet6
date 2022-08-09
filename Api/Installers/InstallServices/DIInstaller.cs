using Api.Installers.Interfaces;

namespace Api.Installers.InstallServices
{
    public class DIInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddControllers();
        }
    }
}
