using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// A card action that a user can take.
/// </summary>
public sealed class ContentCardAction
{
    /// <summary>
    /// Describes the type of action.
    /// </summary>
    /// <value>Describes the type of action.</value>
    public ContentCardActionType? Type { get; set; }

    /// <summary>
    /// The response text from the button click.
    /// </summary>
    /// <value>The response text from the button click.</value>
    public string Text { get; set; }

    /// <summary>
    /// Text to be returned as the payload from a ButtonResponse when a button is clicked. The payload and text are a combination which will have to be unique across each card and carousel in order to determine which button was clicked in that card or carousel.
    /// </summary>
    /// <value>Text to be returned as the payload from a ButtonResponse when a button is clicked. The payload and text are a combination which will have to be unique across each card and carousel in order to determine which button was clicked in that card or carousel.</value>
    public string Payload { get; set; }

    /// <summary>
    /// A URL of a web page to direct the user to.
    /// </summary>
    /// <value>A URL of a web page to direct the user to.</value>
    public string Url { get; set; }
}
