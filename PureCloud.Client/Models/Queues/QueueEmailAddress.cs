namespace PureCloud.Client.Models;

public sealed class QueueEmailAddress
{
    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    public DomainEntityRef Domain { get; set; }

    /// <summary>
    /// Gets or Sets Route
    /// </summary>
    public InboundRoute Route { get; set; }
}
