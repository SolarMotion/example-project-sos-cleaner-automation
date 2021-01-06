using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class CustomLogging
    {
        private static readonly ILogger _logger;

        static CustomLogging()
        {
            // Get application base directory
            string basedir = AppDomain.CurrentDomain.BaseDirectory;

            // Setup Serilog for logging
            _logger = new LoggerConfiguration()
                        .WriteTo.File(basedir + "/Logs/log-.txt", rollingInterval: RollingInterval.Day, retainedFileCountLimit: null)
                        .CreateLogger();
        }

        public static void LogInfo(string info)
        {
            _logger.Information(info);
        }

        public static void LogInfo(Object body)
        {
            _logger.Information("{@Body}", body);
        }

        public static void LogInfo(string text, Object body)
        {
            _logger.Information(text + " {@Body}", body);
        }

        public static void LogError(string error)
        {
            _logger.Error(error);
        }
    }


}
