using System.Collections.Generic;

namespace PureCloud.Client.Models;

/// <summary>
/// Card
/// </summary>
public sealed class Card
{
    /// <summary>
    /// Text to show in the title.
    /// </summary>
    /// <value>Text to show in the title.</value>
    public string Title { get; set; }

    /// <summary>
    /// Text to show in the description.
    /// </summary>
    /// <value>Text to show in the description.</value>
    public string Description { get; set; }

    /// <summary>
    /// URL of an image.
    /// </summary>
    /// <value>URL of an image.</value>
    public string Url { get; set; }

    /// <summary>
    /// The default action to be taken.
    /// </summary>
    /// <value>The default action to be taken.</value>
    public CardAction DefaultAction { get; set; }

    /// <summary>
    /// List of possible action objects.
    /// </summary>
    /// <value>List of possible action objects.</value>
    public IEnumerable<CardAction> Actions { get; set; }
}
