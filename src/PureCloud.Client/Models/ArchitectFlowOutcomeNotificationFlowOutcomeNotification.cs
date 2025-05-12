using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectFlowOutcomeNotificationFlowOutcomeNotification
{
    /// <summary>
    /// The flow outcome ID
    /// </summary>
    /// <value>The flow outcome ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The flow outcome name
    /// </summary>
    /// <value>The flow outcome name</value>
    public string Name { get; set; }

    /// <summary>
    /// The flow outcome description
    /// </summary>
    /// <value>The flow outcome description</value>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets CurrentOperation
    /// </summary>
    public ArchitectFlowOutcomeNotificationArchitectOperation CurrentOperation { get; set; }
}
