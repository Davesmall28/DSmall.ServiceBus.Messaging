namespace DSmall.ServiceBus.Messaging
{
    /// <summary>The ConfigProvider interface.</summary>
    public interface IConfigProvider
    {
        /// <summary>The get setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        string GetCloudSetting(string settingName);

        /// <summary>The get app setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        string GetAppSetting(string settingName);
    }
}