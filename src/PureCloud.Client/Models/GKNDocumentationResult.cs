using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GKNDocumentationResult
{
    /// <summary>
    /// The text or html content for the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The text or html content for the documentation entity. Will be returned in responses for certain entities.</value>
    public string Content { get; set; }

    /// <summary>
    /// URL link for the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>URL link for the documentation entity. Will be returned in responses for certain entities.</value>
    public string Link { get; set; }

    /// <summary>
    /// The title of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The title of the documentation entity. Will be returned in responses for certain entities.</value>
    public string Title { get; set; }

    /// <summary>
    /// The search type. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The search type. Will be returned in responses for certain entities.</value>
    public string Type { get; set; }
}
