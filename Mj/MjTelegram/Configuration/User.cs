namespace MjTelegram.Configuration
{
    /// <summary>
    /// Пользователь
    /// </summary>
    internal class User
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Id пользователя в телеграм
        /// </summary>
        public string Value { get; set; }
    }
}
