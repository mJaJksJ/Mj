using System.Linq;
using MjTelegram.Configuration;
using Config = MjTelegram.Configuration.Configuration;

namespace MjTelegram.Services
{
    /// <summary>
    /// Работа с пользователями
    /// </summary>
    /// <remarks>Требует инициализированного <see cref="Logger"/></remarks>
    internal class UserService
    {
        public static void AddOrUpdateUser(string key, string value)
        {
            var user = Config.Instance.Users.SingleOrDefault(x => x.Key == key);
            
            if (user is not null)
            {
                user.Value = value;
            }
            else
            {
                Config.Instance.Users.Add(new User
                {
                    Key = key,
                    Value = value
                });
            }
            Config.Update();
        }

        /// <returns>true if succes, false if user not exists</returns>
        public static bool RemoveUser(string key)
        {
            var user = Config.Instance.Users.SingleOrDefault(x => x.Key == key);

            if (user is null)
            {
                return false;
            }

            Config.Instance.Users.Remove(user);
            Config.Update();
            return true;
        }
    }
}
