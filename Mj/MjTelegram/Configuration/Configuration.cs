using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using static MjTelegram.Logger;

namespace MjTelegram.Configuration
{
    /// <summary>
    /// Конфиг
    /// </summary>
    internal class Configuration
    {
        #region Instance Props

        /// <summary>
        /// Пользователи
        /// </summary>
        public List<User> Users { get; set; }

        #endregion Instance Props

        public static Configuration Instance { get; private set; }
        private static string FileName => "config.json";

        /// <summary>
        /// Загрузить конфигурацию
        /// </summary>
        /// <remarks>Требует инициализированного <see cref="Logger"/></remarks>
        public static void Init()
        {
            Instance ??= LoadFromJson(FileName);
        }

        public static void Update()
        {
            var json = JsonConvert.SerializeObject(Instance);
            File.WriteAllText(FileName, json);
        }

        private static Configuration LoadFromJson(string filename)
        {
            var path = Path.Combine(Environment.CurrentDirectory, filename);
            path = Path.GetFullPath(path);

            if (!File.Exists(path))
            {
                Log.Information($"File \"{path}\" wasn't exist, but created");
                File.Create(path).Close();
            }

            try
            {
                var config = new Configuration
                {
                    Users = new List<User>()
                };

                var json = File.ReadAllText(path, Encoding.UTF8);
                JsonConvert.PopulateObject(json, config);
                Log.Information($"Loaded config \"{path}\"");
                return config;
            }
            catch (Exception e)
            {
                Log.Error($"Failed to load config \"{path}\": {e.Message}");
                return null;
            }
        }
    }
}
