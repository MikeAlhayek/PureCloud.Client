using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectPromptNotificationPromptNotification
{
    /// <summary>
    /// The prompt ID
    /// </summary>
    /// <value>The prompt ID</value>
    public string Id { get; set; }


    /// <summary>
    /// The prompt name
    /// </summary>
    /// <value>The prompt name</value>
    public string Name { get; set; }


    /// <summary>
    /// The prompt description
    /// </summary>
    /// <value>The prompt description</value>
    public string Description { get; set; }


    /// <summary>
    /// Gets or Sets CurrentOperation
    /// </summary>
    public ArchitectPromptNotificationArchitectOperation CurrentOperation { get; set; }
}
