using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowExecutionLaunchResponse
{
    /// <summary>
    /// The flow execution ID
    /// </summary>
    /// <value>The flow execution ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The flow execution name.
    /// </summary>
    /// <value>The flow execution name.</value>
    public string Name { get; set; }

    /// <summary>
    /// The version of the flow that launched
    /// </summary>
    /// <value>The version of the flow that launched</value>
    public DomainEntityRef FlowVersion { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
