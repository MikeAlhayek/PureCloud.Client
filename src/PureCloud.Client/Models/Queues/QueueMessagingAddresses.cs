namespace PureCloud.Client.Models.Queues;

public sealed class QueueMessagingAddresses
{
    /// <summary>
    /// Gets or Sets SmsAddress
    /// </summary>
    public DomainEntityRef SmsAddress { get; set; }

    /// <summary>
    /// Gets or Sets OpenMessagingRecipient
    /// </summary>
    public DomainEntityRef OpenMessagingRecipient { get; set; }

    /// <summary>
    /// Gets or Sets WhatsAppRecipient
    /// </summary>
    public DomainEntityRef WhatsAppRecipient { get; set; }
}
