using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowExecutionLaunchRequest
{
    /// <summary>
    /// ID of the flow to launch.
    /// </summary>
    /// <value>ID of the flow to launch.</value>
    public string FlowId { get; set; }

    /// <summary>
    /// The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version.
    /// </summary>
    /// <value>The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version.</value>
    public string FlowVersion { get; set; }

    /// <summary>
    /// Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema.
    /// </summary>
    /// <value>Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema.</value>
    public Dictionary<string, object> InputData { get; set; }

    /// <summary>
    /// A displayable name to assign to the new flow execution
    /// </summary>
    /// <value>A displayable name to assign to the new flow execution</value>
    public string Name { get; set; }
}
