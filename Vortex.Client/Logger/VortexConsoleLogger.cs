namespace Vortex.Client.Logger
{
    public class VortexConsoleLogger : IVortexLogger
    {
        public VortexConsoleLogger()
        {

        }
        public void LogError(string message, Exception exception)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} vortex-client   Error          |   {message} \n{exception}");
        }

        public void LogInformation(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} vortex-client   Information    |   {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} vortex-client   Warning        |   {message}");
        }
    }
}
