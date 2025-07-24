using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Button response object representing the click of a structured message button, such as a quick reply.
/// </summary>
public sealed class ConversationContentButtonResponse
{
    // Describes the button that resulted in the Button Response.
    public TypeEnum? Type { get; set; }

    // The response text from the button click.
    public string Text { get; set; }

    // The response payload associated with the clicked button.
    public string Payload { get; set; }
}
