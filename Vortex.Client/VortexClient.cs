using Vortex.Client.Abstractions.Client;
using Vortex.Client.Configurations;

namespace Vortex.Client
{
    public sealed class VortexClient : IClient
    {
        private readonly ClientConfiguration _configuration;

        private VortexClient() : this(new ClientConfiguration())
        {

        }

        private VortexClient(ClientConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static IClientServiceConnection CreateClient()
        {
            return new VortexClient();
        }

        public static IClientServiceConnection CreateClient(ClientConfiguration configuration)
        {
            return new VortexClient(configuration);
        }

        public IClientBuildIntegration AndSettings(Action<ClientSettings> settings)
        {
            settings.Invoke(_configuration.Settings);
            return this;
        }

        public IClientApplicationIntegration ForService(string nodeHost, int nodePort)
        {
            _configuration.ServiceEndpointUrl = new Uri($"{nodeHost}:{nodePort}");

            return this;
        }

        public IClientApplicationIntegration ForService(Uri serviceEndpointUrl)
        {
            _configuration.ServiceEndpointUrl = serviceEndpointUrl;

            return this;
        }

        public IClientSettingsIntegration WithApplication(string applicationName)
        {
            _configuration.Application.ApplicationName = applicationName;

            return this;
        }

        public IClientSettingsIntegration WithApplication(string applicationName, string appKey, string appSecret)
        {
            _configuration.Application.ApplicationName = applicationName;
            _configuration.Application.AppKey = appKey;
            _configuration.Application.AppSecret = appSecret;

            return this;
        }

        public void Build()
        {
            // TODO:/ Check if everything is okay in term of the client.
        }
    }
}
