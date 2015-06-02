namespace DSmall.ServiceBus.Messaging
{
    /// <summary>The configuration provider interface.</summary>
    public interface IConfigProvider
    {
        /// <summary>The get setting.</summary>
        /// <param name="settingName">The setting name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        string GetSetting(string settingName);
    }
}