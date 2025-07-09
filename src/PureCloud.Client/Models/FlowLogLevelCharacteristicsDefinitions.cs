using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowLogLevelCharacteristicsDefinitions
{
    /// <summary>
    /// A list of flow log levels available to the organization.
    /// </summary>
    /// <value>A list of flow log levels available to the organization.</value>
    public IEnumerable<FlowLogLevel> LogLevels { get; set; }

    /// <summary>
    /// A list of characteristics that the loglevels will have that are available to the organization..
    /// </summary>
    /// <value>A list of characteristics that the loglevels will have that are available to the organization..</value>
    public IEnumerable<FlowLogLevelCharacteristicsDefinition> Characteristics { get; set; }
}
