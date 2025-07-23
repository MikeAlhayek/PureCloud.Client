namespace PureCloud.Client.Models;

/// <summary>
/// Contains information about the text associated with a response.
/// </summary>
public sealed class ResponseText
{
    /// <summary>
    /// Response text content.
    /// </summary>
    /// <value>Response text content.</value>
    public string Content { get; set; }

    /// <summary>
    /// Response text content type.
    /// </summary>
    /// <value>Response text content type.</value>
    public ResponseTextContentType? ContentType { get; set; }

    /// <summary>
    /// Response text type.
    /// </summary>
    /// <value>Response text type.</value>
    public ResponseTextType? Type { get; set; }
}