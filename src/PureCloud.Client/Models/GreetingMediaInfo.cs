using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GreetingMediaInfo
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets MediaFileUri
    /// </summary>
    public string MediaFileUri { get; set; }

    /// <summary>
    /// Gets or Sets MediaImageUri
    /// </summary>
    public string MediaImageUri { get; set; }
}
