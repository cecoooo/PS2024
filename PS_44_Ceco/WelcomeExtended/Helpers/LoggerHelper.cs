using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.AzureAppServices;
using WelcomeExtended.Loggers;

namespace WelcomeExtended.Helpers
{
    public static class LoggerHelper
    {
        public static ILogger GetLogger(string categoryName)
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new LoggerProvider());

            return loggerFactory.CreateLogger(categoryName);
        }

        public static ILogger GetFileLogger(string categoryName)
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new Loggers.FileLoggerProvider());

            return loggerFactory.CreateLogger(categoryName);
        }
    }
}
