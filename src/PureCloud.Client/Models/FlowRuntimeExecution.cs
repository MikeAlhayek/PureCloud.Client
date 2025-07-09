using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowRuntimeExecution
{
    /// <summary>
    /// The flow's running status, which indicates whether the flow is running normally or completed, etc.
    /// </summary>
    /// <value>The flow's running status, which indicates whether the flow is running normally or completed, etc.</value>
    public FlowRuntimeExecutionStatusEnum? Status { get; set; }

    /// <summary>
    /// The flow execution ID
    /// </summary>
    /// <value>The flow execution ID</value
    public string Id { get; set; }

    /// <summary>
    /// The flow execution name.
    /// </summary>
    /// <value>The flow execution name.</value>
    public string Name { get; set; }

    /// <summary>
    /// The Version of the flow definition of the flow execution.
    /// </summary>
    /// <value>The Version of the flow definition of the flow execution.</value>
    public FlowVersion FlowVersion { get; set; }

    /// <summary>
    /// The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the flow was launched. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateLaunched { get; set; }

    /// <summary>
    /// The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the flow completed, if applicable. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCompleted { get; set; }

    /// <summary>
    /// The completion reason set at the flow completion time, if applicable.
    /// </summary>
    /// <value>The completion reason set at the flow completion time, if applicable.</value>
    public string CompletionReason { get; set; }

    /// <summary>
    /// Additional information if the flow is in error
    /// </summary>
    /// <value>Additional information if the flow is in error</value>
    public ErrorBody FlowErrorInfo { get; set; }

    /// <summary>
    /// List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows.
    /// </summary>
    /// <value>List of the flow&#39;s output variables, if any. Output variables are only supplied for Completed flows.</value>
    public Dictionary<string, object> OutputData { get; set; }

    /// <summary>
    /// The conversation to which this Flow execution is related
    /// </summary>
    /// <value>The conversation to which this Flow execution is related</value>
    public DomainEntityRef Conversation { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
