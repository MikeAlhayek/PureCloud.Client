using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Set of actions available to the user.
/// </summary>
public sealed class ContentActions
{
    /// <summary>
    /// URL to which the user action should navigate. 
    /// </summary>
    /// <value>URL to which the user action should navigate.</value>
    public string Url { get; set; }

    /// <summary>
    /// Text displayed on the URL action.
    /// </summary>
    /// <value>Text displayed on the URL action.</value>
    public string UrlDisplayText { get; set; }

    /// <summary>
    /// Text value to be sent back if user clicks on a quick reply option.
    /// </summary>
    /// <value>Text value to be sent back if user clicks on a quick reply option.</value>
    public string Textback { get; set; }
}
