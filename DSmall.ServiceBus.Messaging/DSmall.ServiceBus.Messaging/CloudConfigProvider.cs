namespace DSmall.ServiceBus.Messaging
{
    using System.IO;
    using Microsoft.Azure;

    /// <summary>The cloud configuration provider.</summary>
    public class CloudConfigProvider : IConfigProvider
    {
        /// <summary>The get setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetSetting(string settingName)
        {
            var settingValue = CloudConfigurationManager.GetSetting(settingName);

            if (string.IsNullOrWhiteSpace(settingValue))
            {
                var message = string.Format("No Cloud Configuration Setting with name '{0}' found.", settingName);
                throw new InvalidDataException(message);
            }

            return settingValue;
        }
    }
}