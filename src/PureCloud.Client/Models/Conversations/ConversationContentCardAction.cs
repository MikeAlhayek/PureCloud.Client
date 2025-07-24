using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// A card action that a user can take.
/// </summary>
public sealed class ConversationContentCardAction
{
    // Describes the type of action.
    public Type? Type { get; set; }

    // The response text from the button click.
    public string Text { get; set; }

    // Text to be returned as the payload from a ButtonResponse when a button is clicked.
    public string Payload { get; set; }

    // A URL of a web page to direct the user to.
    public string Url { get; set; }
}
