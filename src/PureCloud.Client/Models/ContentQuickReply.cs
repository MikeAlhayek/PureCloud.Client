namespace PureCloud.Client.Models;

/// <summary>
/// Quick reply object.
/// </summary>
public sealed class ContentQuickReply
{
    /// <summary>
    /// Specifies the type of action that is triggered upon clicking the quick reply.
    /// </summary>
    /// <value>Specifies the type of action that is triggered upon clicking the quick reply.</value>
    public ContentQuickReplyAction? Action { get; set; }

    /// <summary>
    /// A unique ID assigned to the quick reply (Deprecated).
    /// </summary>
    /// <value>A unique ID assigned to the quick reply (Deprecated).</value>
    public string Id { get; set; }

    /// <summary>
    /// Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.
    /// </summary>
    /// <value>Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.</value>
    public string Text { get; set; }

    /// <summary>
    /// Content of the payload included in the quick reply response. Could be an ID identifying the quick reply response.
    /// </summary>
    /// <value>Content of the payload included in the quick reply response. Could be an ID identifying the quick reply response.</value>
    public string Payload { get; set; }

    /// <summary>
    /// URL of an image associated with the quick reply.
    /// </summary>
    /// <value>URL of an image associated with the quick reply.</value>
    public string Image { get; set; }
}
