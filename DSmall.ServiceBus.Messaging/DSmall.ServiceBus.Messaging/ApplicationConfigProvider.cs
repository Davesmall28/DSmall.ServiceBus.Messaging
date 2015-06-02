namespace DSmall.ServiceBus.Messaging
{
    using System.Configuration;
    using System.IO;

    /// <summary>The application configuration provider.</summary>
    public class ApplicationConfigProvider : IConfigProvider
    {
        /// <summary>The get setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetSetting(string settingName)
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
