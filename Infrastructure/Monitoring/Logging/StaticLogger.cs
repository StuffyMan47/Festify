using Serilog;
using Serilog.Core;
using Serilog.Sinks.SystemConsole.Themes;

namespace Infrastructure.Monitoring.Logging;

public static class StaticLogger
{
    public static void EnsureInitialized()
    {
        if (Log.Logger is not Logger)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Console(theme: AnsiConsoleTheme.Sixteen)
                .CreateLogger();
        }
    }
}

