using System.Configuration;

namespace FolderCompare
{
    internal static class Config
    {
        private static readonly Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private static readonly KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;
        public static string BaseFolder
        {
            get { return GetSetting("baseFolder"); }
            set { UpdateSetting("baseFolder", value); }
        }
        public static string CompareFolder
        {
            get { return GetSetting("compareFolder"); }
            set { UpdateSetting("compareFolder", value); }
        }

        private static void UpdateSetting(string key, object value)
        {
            if (settings[key] == null)
                settings.Add(key, value.ToString());
            else
                settings[key].Value = value.ToString();
            configFile.Save(ConfigurationSaveMode.Full);
        }
        private static string GetSetting(string key)
        {
            if (settings[key] == null)
                return "";
            else
                return settings[key].Value;
        }
    }
}