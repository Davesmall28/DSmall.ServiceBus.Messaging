namespace DSmall.ServiceBus.Messaging
{
    using System;
    using Microsoft.ServiceBus.Messaging;

    /// <summary>The queue client interface.</summary>
    public interface IQueueClient
    {
        /// <summary>The retrieve message.</summary>
        /// <returns>The <see cref="BrokeredMessage"/>.</returns>
        BrokeredMessage RetrieveMessage();

        /// <summary>The on message.</summary>
        /// <param name="callback">The call back.</param>
        void OnMessage(Action<BrokeredMessage> callback);

        /// <summary>The on message.</summary>
        /// <param name="callback">The call back.</param>
        /// <param name="onMessageOptions">The on message options.</param>
        void OnMessage(Action<BrokeredMessage> callback, OnMessageOptions onMessageOptions);
    } 
}