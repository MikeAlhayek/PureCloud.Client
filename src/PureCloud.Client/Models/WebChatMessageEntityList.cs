using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WebChatMessageEntityList
{
    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<WebChatMessage> Entities { get; set; }

    /// <summary>
    /// Gets or Sets PreviousPage
    /// </summary>
    public string PreviousPage { get; set; }

    /// <summary>
    /// Gets or Sets Next
    /// </summary>
    public string Next { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }
}
