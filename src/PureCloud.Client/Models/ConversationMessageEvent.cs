namespace PureCloud.Client.Models;

/// <summary>
/// ConversationMessageEvent
/// </summary>
public sealed class ConversationMessageEvent
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    public string EventType { get; set; }

    /// <summary>
    /// Gets or Sets MessageId
    /// </summary>
    public string MessageId { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public string ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets SenderId
    /// </summary>
    public string SenderId { get; set; }

    /// <summary>
    /// Gets or Sets MessageText
    /// </summary>
    public string MessageText { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets MessageData
    /// </summary>
    public object MessageData { get; set; }
}
