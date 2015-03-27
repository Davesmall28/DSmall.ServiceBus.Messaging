namespace DSmall.ServiceBus.Messaging
{
    using Microsoft.ServiceBus.Messaging;

    /// <summary>The queue client interface.</summary>
    public interface IQueueClient
    {
        /// <summary>The retrieve message.</summary>
        /// <returns>The <see cref="BrokeredMessage"/>.</returns>
        BrokeredMessage RetrieveMessage();
    } 
}