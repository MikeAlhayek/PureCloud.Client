using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ArchitectJobStateResponse
{
    /// <summary>
    /// Status of the Architect Job
    /// </summary>
    /// <value>Status of the Architect Job</value>
    public ArchitectJobStateResponseStatusEnum? Status { get; set; }

    /// <summary>
    /// The command executed by the Architect Job
    /// </summary>
    /// <value>The command executed by the Architect Job</value>
    public ArchitectJobStateResponseCommandEnum? Command { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Flow created from the Architect Job
    /// </summary>
    /// <value>Flow created from the Architect Job</value>
    public AddressableEntityRef Flow { get; set; }

    /// <summary>
    /// Warnings and Errors messages of the Architect Job
    /// </summary>
    /// <value>Warnings and Errors messages of the Architect Job</value>
    public IEnumerable<ArchitectJobMessage> Messages { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
