using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectFlowNotificationFlowNotification
{
    /// <summary>
    /// The flow ID
    /// </summary>
    /// <value>The flow ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The flow name
    /// </summary>
    /// <value>The flow name</value>
    public string Name { get; set; }

    /// <summary>
    /// The flow description
    /// </summary>
    /// <value>The flow description</value>
    public string Description { get; set; }

    /// <summary>
    /// The flow deleted state
    /// </summary>
    /// <value>The flow deleted state</value>
    public bool? Deleted { get; set; }

    /// <summary>
    /// Gets or Sets CheckedInVersion
    /// </summary>
    public ArchitectFlowNotificationFlowVersion CheckedInVersion { get; set; }

    /// <summary>
    /// A bare-bones flow version object
    /// </summary>
    /// <value>A bare-bones flow version object</value>
    public ArchitectFlowNotificationFlowVersion SavedVersion { get; set; }

    /// <summary>
    /// A bare-bones flow version object
    /// </summary>
    /// <value>A bare-bones flow version object</value>
    public ArchitectFlowNotificationFlowVersion PublishedVersion { get; set; }

    /// <summary>
    /// Gets or Sets CurrentOperation
    /// </summary>
    public ArchitectFlowNotificationArchitectOperation CurrentOperation { get; set; }
}
