using System;

namespace KintoHub.Logging
{
    [Flags]
    public enum LogOptions
    {
        NONE = 0,
        DISABLE_FLUENTD = 1,
        DISABLE_ASP_NET = 2
    }
}
