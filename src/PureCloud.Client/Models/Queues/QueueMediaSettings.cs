namespace PureCloud.Client.Models;

public sealed class QueueMediaSettings
{
    /// <summary>
    /// The queue media settings for call interactions.
    /// </summary>
    /// <value>The queue media settings for call interactions.</value>
    public MediaSettings Call { get; set; }

    /// <summary>
    /// The queue media settings for callback interactions.
    /// </summary>
    /// <value>The queue media settings for callback interactions.</value>
    public CallbackMediaSettings Callback { get; set; }

    /// <summary>
    /// The queue media settings for chat interactions.
    /// </summary>
    /// <value>The queue media settings for chat interactions.</value>
    public MediaSettings Chat { get; set; }

    /// <summary>
    /// The queue media settings for email interactions.
    /// </summary>
    /// <value>The queue media settings for email interactions.</value>
    public EmailMediaSettings Email { get; set; }

    /// <summary>
    /// The queue media settings for message interactions.
    /// </summary>
    /// <value>The queue media settings for message interactions.</value>
    public MessageMediaSettings Message { get; set; }
}
