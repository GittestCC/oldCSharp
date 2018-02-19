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

        public ILogger Provide(LogOptions options)
        {
            var fluentdHost = Environment.GetEnvironmentVariable(FlientdHostEnvVar);

            var config = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .WriteTo.LiterateConsole();

            if ((options & LogOptions.DISABLE_ASP_NET) == LogOptions.DISABLE_ASP_NET)
            {
                config.MinimumLevel.Override("Microsoft", LogEventLevel.Information);
            }

            bool fluentDisabled = (options & LogOptions.DISABLE_FLUENTD) == LogOptions.DISABLE_FLUENTD;

            if (fluentDisabled == false)
            {
                config.WriteTo.Fluentd(new FluentdSinkOptions(fluentdHost, DefaultFluentdPort));
            }

            var logger = config.CreateLogger();

            logger.Information("FluentD Logger Enabled: {0}, host {1}, port {2}", (fluentDisabled == false), fluentdHost, DefaultFluentdPort);

            return new SeriLogger(logger);
        }
    }
}
