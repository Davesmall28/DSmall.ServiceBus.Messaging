namespace DSmall.ServiceBus.Messaging
{
    using System.Configuration;
    using System.IO;
    using Microsoft.Azure;

    /// <summary>The config provider.</summary>
    public class ConfigProvider : IConfigProvider
    {
        /// <summary>The get setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetCloudSetting(string settingName)
        {
            var settingValue = CloudConfigurationManager.GetSetting(settingName);

            if (string.IsNullOrWhiteSpace(settingValue))
            {
                var message = string.Format("No Cloud Configuration Setting with name '{0}' found.", settingName);
                throw new InvalidDataException(message);
            }

            return settingValue;
        }

        /// <summary>The get app setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetAppSetting(string settingName)
        {
            var settingValue = ConfigurationManager.AppSettings[settingName];

            if (string.IsNullOrWhiteSpace(settingValue))
            {
                var message = string.Format("No Application Configuration Setting with name '{0}' found.", settingName);
                throw new InvalidDataException(message);
            }

            return settingValue;
        }
    }
}