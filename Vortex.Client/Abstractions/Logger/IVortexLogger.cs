namespace Vortex.Client.Logger
{
    public interface IVortexLogger
    {
        void LogInformation(string message);
        void LogWarning(string message);
        void LogError(string message, Exception exception);
    }
}
