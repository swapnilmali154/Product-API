using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Logging
{
    public class LogHelper : ILogHelper
    {
        private ILogger _logger;
        private readonly ILoggerFactory _loggerFactory;
        public LogHelper(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }
        public void Log(LogEntry entry)
        {
            CreateLogger();
            using (_logger.BeginScope(entry.ExtraDataDictionary))
            {
                _logger.Log(GetMicrosoftLogLevel(entry.Type), entry.Exception, entry.Message);
            }
        }

        private LogLevel GetMicrosoftLogLevel(LogType type)
        {
            switch (type)
            {
                case LogType.Debug:
                    return LogLevel.Debug;                      
                case LogType.Warning:
                    return LogLevel.Warning;
                case LogType.Error:
                    return LogLevel.Error;
                default:
                    return LogLevel.Information;
            }
        }

        private void CreateLogger()
        {
            if(_logger == null)
            {
                _logger = _loggerFactory.CreateLogger("LogHelper");
            }
        }

        public void Log(LogType type, Exception ex, string message)
        {
            Log(new LogEntry()
            {
                Type = type,
                Exception = ex,
                Message = message
            });
        }
    }
}
