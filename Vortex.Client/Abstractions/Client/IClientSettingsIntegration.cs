using Vortex.Client.Configurations;

namespace Vortex.Client.Abstractions.Client
{
    public interface IClientSettingsIntegration
    {
        IClientBuildIntegration AndSettings(Action<ClientSettings> settings);
        void Build();
    }
}
