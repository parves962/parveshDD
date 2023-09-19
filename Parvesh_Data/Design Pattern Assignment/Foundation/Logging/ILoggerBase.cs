using System;

namespace Foundation.Logging
{
    public interface ILoggerBase
    {
        bool IsDebugEnabled { get; }
        bool IsErrorEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsTraceEnabled { get; }
        bool IsWarningEnabled { get; }

        void LogDebug(object message);
        void LogError(Exception exceptionToLog);
        void LogError(object message, Exception exception);
        void LogError(string message);
        void LogInfo(object message);
        void LogTrace(object message);
        void LogWarning(object message);
    }
}