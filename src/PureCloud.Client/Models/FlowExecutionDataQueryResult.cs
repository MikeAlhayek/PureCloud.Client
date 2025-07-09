using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowExecutionDataQueryResult
{
    /// <summary>
    /// The type of flow.
    /// </summary>
    /// <value>The type of flow.</value>
    public FlowExecutionDataQueryResultFlowTypeEnum? FlowType { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    /// The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? EndDateTime { get; set; }

    /// <summary>
    /// The id of the flow that was executed.
    /// </summary>
    /// <value>The id of the flow that was executed.</value>
    public string FlowId { get; set; }

    /// <summary>
    /// The version of the flow that was executed.
    /// </summary>
    /// <value>The version of the flow that was executed.</value>
    public string FlowVersion { get; set; }

    /// <summary>
    /// The id of the conversation that executed this flow.
    /// </summary>
    /// <value>The id of the conversation that executed this flow.</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// The id of the workitem that executed this flow.
    /// </summary>
    /// <value>The id of the workitem that executed this flow.</value>
    public string WorkitemId { get; set; }

    /// <summary>
    /// If the flow errored out this is the reason.
    /// </summary>
    /// <value>If the flow errored out this is the reason.</value>
    public string FlowErrorReason { get; set; }

    /// <summary>
    /// If the flow had a warning, this is the reason.
    /// </summary>
    /// <value>If the flow had a warning, this is the reason.</value>
    public string FlowWarningReason { get; set; }

    /// <summary>
    /// The name of the flow.
    /// </summary>
    /// <value>The name of the flow.</value>
    public string FlowName { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
