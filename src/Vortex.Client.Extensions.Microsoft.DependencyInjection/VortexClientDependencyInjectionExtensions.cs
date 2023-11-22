using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vortex.Client.Configurations;

namespace Vortex.Client.Extensions.Microsoft.DependencyInjection
{
    public static class VortexClientDependencyInjectionExtensions
    {
        public static void AddVortex(this IServiceCollection services, Action<ClientConfiguration> config)
        {
            var clientConfig = new ClientConfiguration();
            config.Invoke(clientConfig);

            services.AddSingleton<IVortexClientFactory>(provider =>
            {
                return new VortexClientFactory(clientConfig);
            });
        }

        public static void UseVortex(this IApplicationBuilder app)
        {
            var service = app.ApplicationServices.GetService<IVortexClientFactory>();
            if (service == null)
            {
                throw new Exception("Error: Vortex has not been added to the ServiceCollection. " +
                    "Please ensure Vortex is correctly registered in the ServiceCollection.");
            }
        }
    }
}
