namespace Vortex.Client.Abstractions.Client
{
    public interface IClientServiceConnection
    {
        IClientApplicationIntegration ForService(string nodeHost, int nodePort);
        IClientApplicationIntegration ForService(Uri serviceEndpointUrl);
    }
}
