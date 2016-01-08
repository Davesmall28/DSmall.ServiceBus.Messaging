namespace DSmall.ServiceBus.Messaging
{
    using System;
    using Microsoft.ServiceBus.Messaging;

    /// <summary>The dSmall cloud queue client.</summary>
    public class DSmallQueueClient : IQueueClient
    {
        private const string ConnectionStringSettingName = "ServiceBusConnectionString";
        private const string QueueNameSettingName = "QueueName";
        private readonly IConfigProvider configProvider;
        private readonly QueueClient queueClient;

        /// <summary>Initialises a new instance of the <see cref="DSmallQueueClient"/> class.</summary>
        /// <param name="configProvider">The config provider.</param>
        public DSmallQueueClient(IConfigProvider configProvider)
        {
            this.configProvider = configProvider;
        }

        /// <summary>Initialises a new instance of the <see cref="DSmallQueueClient"/> class.</summary>
        /// <param name="queueClient">The queue client.</param>
        protected DSmallQueueClient(QueueClient queueClient)
        {
            this.queueClient = queueClient;
        }

        /// <summary>The get queue client.</summary>
        /// <returns>The <see cref="IQueueClient"/>.</returns>
        public IQueueClient GetQueueClient()
        {
            var queueName = configProvider.GetSetting(QueueNameSettingName);
            var connectionString = configProvider.GetSetting(ConnectionStringSettingName);

            return new DSmallQueueClient(QueueClient.CreateFromConnectionString(connectionString, queueName));
        }

        /// <summary>The retrieve message.</summary>
        /// <returns>The <see cref="BrokeredMessage"/>.</returns>
        public BrokeredMessage RetrieveMessage()
        {
            return queueClient.Receive();
        }

        /// <summary>The on message.</summary>
        /// <param name="callback">The call back.</param>
        public void OnMessage(Action<BrokeredMessage> callback)
        {
            queueClient.OnMessage(callback);
        }

        /// <summary>The on message.</summary>
        /// <param name="callback">The call back.</param>
        /// <param name="onMessageOptions">The on message options.</param>
        public void OnMessage(Action<BrokeredMessage> callback, OnMessageOptions onMessageOptions)
        {
            queueClient.OnMessage(callback, onMessageOptions);
        }
    }
}