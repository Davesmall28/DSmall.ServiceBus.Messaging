namespace DSmall.ServiceBus.Messaging
{
    using System.Configuration;
    using Microsoft.Azure;

    /// <summary>The config provider.</summary>
    public class ConfigProvider : IConfigProvider
    {
        /// <summary>The get setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetCloudSetting(string settingName)
        {
            return CloudConfigurationManager.GetSetting(settingName);
        }

        /// <summary>The get app setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetAppSetting(string settingName)
        {
            return ConfigurationManager.AppSettings[settingName];
        }
    }
}