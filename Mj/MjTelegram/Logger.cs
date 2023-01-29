using Serilog;

namespace MjTelegram
{
    internal static class Logger
    {
        public static ILogger Log { get; private set; }

        public static void Init(ILogger logger)
        {
            Log ??= logger;
        }
    }
}
