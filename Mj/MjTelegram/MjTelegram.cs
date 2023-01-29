using Serilog;
using Config = MjTelegram.Configuration.Configuration;

namespace MjTelegram
{
    /// <summary>
    /// Работа с телеграм методами
    /// </summary>
    public class MjTelegram
    {
        public string AccessToken { get; init; }

        /// <summary>
        /// .ctor
        /// </summary>
        public MjTelegram(
            string accessToken,
            ILogger logger)
        {
            AccessToken = accessToken;
            Logger.Init(logger);
            Config.Init();
        }
    }
}
