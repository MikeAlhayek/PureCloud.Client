using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification
{
    /// <summary>
    /// The organization&#39;s new dependency tracking build status
    /// </summary>
    /// <value>The organization&#39;s new dependency tracking build status</value>
    public string Status { get; set; }


    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public ArchitectDependencyTrackingBuildNotificationUser User { get; set; }


    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    public ArchitectDependencyTrackingBuildNotificationClient Client { get; set; }


    /// <summary>
    /// The time the last build started, in ISO 8601 format
    /// </summary>
    /// <value>The time the last build started, in ISO 8601 format</value>
    public DateTime? StartTime { get; set; }
}
