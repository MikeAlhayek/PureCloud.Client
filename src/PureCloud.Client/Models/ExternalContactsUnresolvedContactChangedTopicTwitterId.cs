using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsUnresolvedContactChangedTopicTwitterId
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
    /// Gets or Sets ScreenName
    /// </summary>
    public string ScreenName { get; set; }

    /// <summary>
    /// Gets or Sets Verified
    /// </summary>
    public bool? Verified { get; set; }

    /// <summary>
    /// Gets or Sets ProfileUrl
    /// </summary>
    public string ProfileUrl { get; set; }
}
