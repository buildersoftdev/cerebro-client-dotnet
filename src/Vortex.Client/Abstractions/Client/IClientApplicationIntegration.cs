namespace Vortex.Client.Abstractions.Client
{
    public interface IClientApplicationIntegration
    {
        IClientSettingsIntegration WithApplication(string applicationName);
        IClientSettingsIntegration WithApplication(string applicationName, string appKey, string appSecret);

        // IClientSettingsIntegration WithApplication(string applicationName, string fileKey);
    }
}
