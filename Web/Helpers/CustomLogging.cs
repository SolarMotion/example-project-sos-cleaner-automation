using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Helpers
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

        public static void LogError(string error)
        {
            _logger.Error(error);
        }
    }
}