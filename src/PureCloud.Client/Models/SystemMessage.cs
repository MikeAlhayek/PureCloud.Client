namespace PureCloud.Client.Models;

public sealed class SystemMessage
{
    /// <summary>
    /// Gets or Sets SystemTopicType
    /// </summary>
    public SystemTopicType? SystemTopicType { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    public SystemMessageReasonEnum? Reason { get; set; }

    /// <summary>
    /// Gets or Sets ChannelId
    /// </summary>
    public string ChannelId { get; set; }

    /// <summary>
    /// Gets or Sets CorrelationId
    /// </summary>
    public string CorrelationId { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationId
    /// </summary>
    public string OrganizationId { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets OauthClientId
    /// </summary>
    public string OauthClientId { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public Dictionary<string, object> Data { get; set; }
}
