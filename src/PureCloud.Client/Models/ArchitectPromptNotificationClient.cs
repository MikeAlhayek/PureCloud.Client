using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectPromptNotificationClient
{
    /// <summary>
    /// The ID of the client.
    /// </summary>
    /// <value>The ID of the client.</value>
    public string Id { get; set; }


    /// <summary>
    /// The name of the client, if available.
    /// </summary>
    /// <value>The name of the client, if available.</value>
    public string Name { get; set; }
}
