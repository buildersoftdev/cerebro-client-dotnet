using Vortex.Client.Configurations;

namespace Vortex.Client
{
    public class VortexClientFactory : IVortexClientFactory
    {
        private readonly ClientConfiguration _configuration;
        public VortexClientFactory(ClientConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IClient CreateVortexClient()
        {
            return (IClient)VortexClient.CreateClient(_configuration);
        }
    }
}
