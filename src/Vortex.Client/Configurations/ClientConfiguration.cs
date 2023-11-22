using Vortex.Client.Logger;

namespace Vortex.Client.Configurations
{
    public class ClientConfiguration
    {
        public Uri ServiceEndpointUrl { get; set; }
        public ClientSettings Settings { get; set; }

        public Application Application { get; set; }

        public ClientConfiguration()
        {
            Settings = new ClientSettings();
            Application = new Application() { ApplicationName = "default" };
        }
    }

    public class ClientSettings
    {
        public bool IsAutoReconnectEnabled { get; set; }
        public int ConnectionTimeoutMilliseconds { get; set; }
        public int ReconnectionTimeoutMilliseconds { get; set; }

        public LoggerConfiguration LoggerConfiguration { get; set; }

        public ClientSettings()
        {
            IsAutoReconnectEnabled = true;
            ConnectionTimeoutMilliseconds = 3000;
            ReconnectionTimeoutMilliseconds = 1000;

            LoggerConfiguration = new LoggerConfiguration();
        }
    }

    public class LoggerConfiguration
    {
        private readonly IVortexLogger _logger;

        public LoggerConfiguration()
        {
            _logger = new VortexConsoleLogger();
        }

        public LoggerConfiguration(IVortexLogger logger)
        {
            _logger = logger;
        }

        public IVortexLogger GetVortexLogger()
        {
            return _logger;
        }
    }

    public class Application
    {
        public string ApplicationName { get; set; }

        public string AppKey { get; set; }
        public string AppSecret { get; set; }
    }
}
