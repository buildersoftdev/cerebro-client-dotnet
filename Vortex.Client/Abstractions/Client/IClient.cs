using Vortex.Client.Abstractions.Client;

namespace Vortex.Client
{
    public interface IClient : IClientServiceConnection, IClientApplicationIntegration, IClientSettingsIntegration, IClientBuildIntegration
    {

    }
}
