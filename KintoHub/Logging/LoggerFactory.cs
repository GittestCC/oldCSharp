using System;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.Fluentd;

namespace KintoHub.Logging
{
    /// <summary>
    /// Returns Kinto-Friendly logger which stores logs to the global ecosystem for your account to access
    /// 
    /// @author DisTurBinG
    /// </summary>
    public class LoggerFactory
    {
        private const string FlientdHostEnvVar = "FLUENTD_HOST";
        private const int DefaultFluentdPort = 5170;

        public ILogger Provide()
        {
            var fluentdHost = Environment.GetEnvironmentVariable(FlientdHostEnvVar);

            return new SeriLogger(new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Fluentd(new FluentdSinkOptions(fluentdHost, DefaultFluentdPort)
                {
                    NoDelay = true
                })
                .WriteTo.LiterateConsole()
                .CreateLogger());
        }
    }
}
