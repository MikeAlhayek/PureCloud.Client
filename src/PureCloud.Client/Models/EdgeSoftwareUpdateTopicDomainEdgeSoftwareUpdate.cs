using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    public EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdateStatusEnum? Status { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets DownloadStartTime
    /// </summary>
    public DateTime? DownloadStartTime { get; set; }

    /// <summary>
    /// Gets or Sets ExecuteStartTime
    /// </summary>
    public DateTime? ExecuteStartTime { get; set; }

    /// <summary>
    /// Gets or Sets ExecuteStopTime
    /// </summary>
    public DateTime? ExecuteStopTime { get; set; }
}
