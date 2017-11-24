using System;

namespace KintoHub.Logging
{
    /// <summary>
    /// Wrapper Serilog ILogger so child classes do not need to know about SeriLog as a dependency
    ///  
    /// @author DisTurBinG
    /// </summary>
    public interface ILogger
    {
        void Information(Exception exception, string messageTemplate, params object[] paramz);
        void Information(string messageTemplate, params object[] paramz);
        void Warning(Exception exception, string messageTemplate, params object[] paramz);
        void Warning(string messageTemplate, params object[] paramz);
        void Error(Exception exception, string messageTemplate, params object[] paramz);
        void Error(string messageTemplate, params object[] paramz);
        void Fatal(Exception exception, string messageTemplate, params object[] paramz);
        void Fatal(string messageTemplate, params object[] paramz);
        void Debug(string messageTemplate, params object[] paramz);
        void Debug(Exception exception, string messageTemplate, params object[] paramz);

    }
}
