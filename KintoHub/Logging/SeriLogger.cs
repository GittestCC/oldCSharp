using System;

namespace KintoHub.Logging
{
    /// <summary>
    /// Logger implementation for SeriLogger
    /// 
    /// @author DisTurBinG
    /// </summary>
    public class SeriLogger : ILogger 
    {
        private readonly Serilog.ILogger _logger;

        public SeriLogger(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public void Information(Exception exception, string messageTemplate, params object[] paramz)
        {
            _logger.Information(exception, messageTemplate, paramz);
        }

        public void Information(string messageTemplate, params object[] paramz)
        {
            _logger.Information(messageTemplate, paramz);
        }

        public void Warning(Exception exception, string messageTemplate, params object[] paramz)
        {
            _logger.Warning(exception, messageTemplate, paramz);
        }

        public void Warning(string messageTemplate, params object[] paramz)
        {
            _logger.Warning(messageTemplate, paramz);
        }

        public void Error(Exception exception, string messageTemplate, params object[] paramz)
        {
            _logger.Error(exception, messageTemplate, paramz);
        }

        public void Error(string messageTemplate, params object[] paramz)
        {
            _logger.Error(messageTemplate, paramz);
        }

        public void Fatal(Exception exception, string messageTemplate, params object[] paramz)
        {
            _logger.Fatal(exception, messageTemplate, paramz);
        }

        public void Fatal(string messageTemplate, params object[] paramz)
        {
            _logger.Fatal(messageTemplate, paramz);
        }

        public void Debug(string messageTemplate, params object[] paramz)
        {
            _logger.Debug(messageTemplate, paramz);
        }

        public void Debug(Exception exception, string messageTemplate, params object[] paramz)
        {
            _logger.Debug(exception, messageTemplate, paramz);
        }
    }
}
