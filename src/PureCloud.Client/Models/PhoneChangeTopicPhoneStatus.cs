using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PhoneChangeTopicPhoneStatus
{
    /// <summary>
    /// Gets or Sets OperationalStatus
    /// </summary>
    public PhoneChangeTopicPhoneStatusOperationalStatusEnum? OperationalStatus { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Edge
    /// </summary>
    public PhoneChangeTopicEdgeReference Edge { get; set; }

    /// <summary>
    /// Gets or Sets Provision
    /// </summary>
    public PhoneChangeTopicProvisionInfo Provision { get; set; }

    /// <summary>
    /// Gets or Sets LineStatuses
    /// </summary>
    public IEnumerable<PhoneChangeTopicLineStatus> LineStatuses { get; set; }

    /// <summary>
    /// Gets or Sets EventCreationTime
    /// </summary>
    public DateTime? EventCreationTime { get; set; }
}
