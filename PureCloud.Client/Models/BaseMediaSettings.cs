namespace PureCloud.Client.Models;

public sealed class BaseMediaSettings
{
    /// <summary>
    /// Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.
    /// </summary>
    /// <value>Indicates if auto-answer is enabled for the given media type or subtype (default is false).  Subtype settings take precedence over media type settings.</value>
    public bool? EnableAutoAnswer { get; set; }
}
