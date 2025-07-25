using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContentPostback
{
    /// <summary>
    /// An ID assigned to the button response.
    /// </summary>
    /// <value>An ID assigned to the button response.</value>
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
