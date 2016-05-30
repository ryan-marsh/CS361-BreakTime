using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Json;

namespace BreakTime
{
    public static class Settings
    {
        static Settings()
        {
            // read user settings from disk
            ReadUserSettings();
        }

        private static void ReadUserSettings()
        {
            UserSettings settings = null;
            // see: http://stackoverflow.com/questions/18242429/how-to-deserialize-json-data
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(UserSettings));

            try
            {
                // try to read the user's settings
                using (FileStream settingsFile = new FileStream(SettingsFilePath, FileMode.Open, FileAccess.Read))
                {
                    settings = (UserSettings)serializer.ReadObject(settingsFile);
                }
            }
            catch (Exception)
            {
                // if the settings file can't be read (doesn't exist, invalid formatting, etc.)
                // then simply create new default settings
                settings = new UserSettings();
            }

            Interval = TimeSpan.FromSeconds(settings.interval);
            UserName = settings.username;
            WhatHurts = settings.hurts;
        }

        public static void WriteUserSettings()
        {
            // see: http://stackoverflow.com/questions/18242429/how-to-deserialize-json-data
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(UserSettings));

            try
            {
                // try to write out the user's settings
                using (FileStream settingsFile = new FileStream(SettingsFilePath, FileMode.Create, FileAccess.Write))
                {
                    // rewrites the whole file--not a great way to go, but can be modified in the future
                    serializer.WriteObject(settingsFile, new UserSettings() { username = UserName, interval = (int)Interval.TotalSeconds, hurts = WhatHurts });
                }
            }
            catch (Exception)
            {
            }
        }

        #region Settings Not User Modifiable

        /// <summary>
        /// Gets the string format to use for the user greeting.
        /// </summary>
        public static readonly string UserGreetingFormat = "It's time for a break, {0}!";

        /// <summary>
        /// Gets the path to the settings file that stores user-modifiable settings.
        /// </summary>
        public static readonly string SettingsFilePath = "user_settings.json";

        /// <summary>
        /// Gets the scheme for database access.
        /// </summary>
        public static readonly string Scheme = "http";

        /// <summary>
        /// Gets the database server string.
        /// </summary>
        public static readonly string Server = "sittingdbase.appspot.com";

        /// <summary>
        /// Gets the path string to grab an encouragement from the server.
        /// </summary>
        public static readonly string EncouragementPath = "encourage";

        /// <summary>
        /// Gets the path string to grab a stretch object from the server.
        /// </summary>
        public static readonly string StretchPath = "stretch";

        /// <summary>
        /// Gets the path string to the resources page from the server.
        /// </summary>
        public static readonly string ResourcesPath = "/resources/resources.html";

        #endregion

        #region Settings User Modifiable

        /// <summary>
        /// Gets the user's specified username.
        /// </summary>
        public static string UserName = "User";

        /// <summary>
        /// Gets the user's specified stretch break interval.
        /// </summary>
        public static TimeSpan Interval = TimeSpan.FromMinutes(45.0);

        /// <summary>
        /// Gets the user's indicated hurts.
        /// </summary>
        public static Hurts WhatHurts = new Hurts();

        #endregion
    }
}
