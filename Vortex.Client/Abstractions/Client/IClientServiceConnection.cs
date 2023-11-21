namespace Vortex.Client.Abstractions.Client
{
    public interface IClientServiceConnection
    {
        IClientApplicationIntegration ForService(string nodeHost, int nodePort);
    }
}
