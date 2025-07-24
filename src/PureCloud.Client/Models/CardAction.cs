namespace PureCloud.Client.Models;

/// <summary>       
/// A card action that a user can take.
/// </summary>
public sealed class CardAction
{
    /// <summary>
    /// Describes the type of action.
    /// </summary>
    /// <value>Describes the type of action.</value>
    public CardActionTypeEnum? Type { get; set; }

    /// <summary>
    /// The response text from the button click.
    /// </summary>
    /// <value>The response text from the button click.</value>
    public string Text { get; set; }

    /// <summary>
    /// Content of the textback payload after clicking a button.
    /// </summary>
    /// <value>Content of the textback payload after clicking a button.</value>
    public string Payload { get; set; }

    /// <summary>
    /// The location of the image file associated with action.
    /// </summary>
    /// <value>The location of the image file associated with action.</value>
    public string Url { get; set; }

    /// <summary>
    /// Indicates if the card option is selected by end customer.
    /// </summary>
    /// <value>Indicates if the card option is selected by end customer.</value>
    public bool? IsSelected { get; set; }
}
