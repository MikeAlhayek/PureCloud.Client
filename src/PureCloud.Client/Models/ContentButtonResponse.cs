namespace PureCloud.Client.Models;

/// <summary>
/// Button response object representing the click of a structured message button, such as a quick reply.
/// </summary>
public sealed class ContentButtonResponse
{
    /// <summary>
    /// Describes the button that resulted in the Button Response.
    /// </summary>
    /// <value>Describes the button that resulted in the Button Response.</value>
    public ContentButtonResponseType? Type { get; set; }

    /// <summary>
    /// An ID assigned to the button response (Deprecated).
    /// </summary>
    /// <value>An ID assigned to the button response (Deprecated).</value>
    public string Id { get; set; }

    /// <summary>
    /// The response text from the button click.
    /// </summary>
    /// <value>The response text from the button click.</value>
    public string Text { get; set; }

    /// <summary>
    /// The response payload associated with the clicked button.
    /// </summary>
    /// <value>The response payload associated with the clicked button.</value>
    public string Payload { get; set; }
}
