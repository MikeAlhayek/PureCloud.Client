using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowLogLevelCharacteristicsDefinition
{
    /// <summary>
    /// The minimum level required for this characteristic to be enabled.
    /// </summary>
    /// <value>The minimum level required for this characteristic to be enabled.</value>
    public FlowLogLevelCharacteristicsDefinitionMinimumLevelEnum? MinimumLevel { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// If set, this is the id of the characteristic that this one depends on and it must be enabled for this to be enabled.
    /// </summary>
    /// <value>If set, this is the id of the characteristic that this one depends on and it must be enabled for this to be enabled.</value>
    public FlowCharacteristics DependsOn { get; set; }
}
