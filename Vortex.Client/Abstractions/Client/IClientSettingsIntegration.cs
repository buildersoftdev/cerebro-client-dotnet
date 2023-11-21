namespace Vortex.Client.Abstractions.Client
{
    public interface IClientSettingsIntegration
    {
        IClientBuildIntegration AndSettings(/*add later, add parameter configs as action here*/);
        void Build();
    }
}
