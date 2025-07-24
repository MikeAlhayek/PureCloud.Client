using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessageMediaAttachment
/// </summary>
public sealed class MessageMediaAttachment
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    public string MediaType { get; set; }
}
