using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicFlowExecutionHistory
{
    /// <summary>
    /// If applicable, the type of message platform from which the message originated.
    /// </summary>
    /// <value>If applicable, the type of message platform from which the message originated.</value>
    public V2FlowExecutionDataFlowidTopicFlowExecutionHistoryMessageTypeEnum? MessageType { get; set; }

    /// <summary>
    /// The execution identifier which represents this unique instance of the flow that ran.
    /// </summary>
    /// <value>The execution identifier which represents this unique instance of the flow that ran.</value>
    public string ExecutionId { get; set; }

    /// <summary>
    /// The Genesys Cloud conversation identifier associated with this flow instance execution data.
    /// </summary>
    /// <value>The Genesys Cloud conversation identifier associated with this flow instance execution data.</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// The division identifier for the division associated with the flow for this flow instance.
    /// </summary>
    /// <value>The division identifier for the division associated with the flow for this flow instance.</value>
    public string DivisionId { get; set; }

    /// <summary>
    /// The end date time for this flow instance execution data.
    /// </summary>
    /// <value>The end date time for this flow instance execution data.</value>
    public DateTime? EndDateTime { get; set; }

    /// <summary>
    /// The public endpoint a user can use to retrieve the full historical log from the service.
    /// </summary>
    /// <value>The public endpoint a user can use to retrieve the full historical log from the service.</value>
    public string Endpoint { get; set; }

    /// <summary>
    /// If the flow invoked error handling, an array of errors.
    /// </summary>
    /// <value>If the flow invoked error handling, an array of errors.</value>
    public IEnumerable<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Errors { get; set; }

    /// <summary>
    /// An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot.
    /// </summary>
    /// <value>An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot.</value>
    public IEnumerable<V2FlowExecutionDataFlowidTopicExecution> Execution { get; set; }

    /// <summary>
    /// Provides information about why a flow ended.
    /// </summary>
    /// <value>Provides information about why a flow ended.</value>
    public string FlowExitReason { get; set; }

    /// <summary>
    /// The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect.
    /// </summary>
    /// <value>The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect.</value>
    public string FlowId { get; set; }

    /// <summary>
    /// Whether the flow that ran for this flow instance execution data was in debug mode.
    /// </summary>
    /// <value>Whether the flow that ran for this flow instance execution data was in debug mode.</value>
    public bool? FlowIsDebug { get; set; }

    /// <summary>
    /// If true, the execution items in this event have been truncated to be deliverable.
    /// </summary>
    /// <value>If true, the execution items in this event have been truncated to be deliverable.</value>
    public bool? ExecutionItemsTruncated { get; set; }

    /// <summary>
    /// The flow type of the Architect flow that was run.
    /// </summary>
    /// <value>The flow type of the Architect flow that was run.</value>
    public string FlowType { get; set; }

    /// <summary>
    /// The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be &#39;debug&#39;
    /// </summary>
    /// <value>The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be &#39;debug&#39;</value>
    public string FlowVersion { get; set; }

    /// <summary>
    /// Gets or Sets InvokingContext
    /// </summary>
    public V2FlowExecutionDataFlowidTopicInvokingContext InvokingContext { get; set; }

    /// <summary>
    /// The start date time for this flow instance execution data.
    /// </summary>
    /// <value>The start date time for this flow instance execution data.</value>
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    /// If the flow encountered a warning during execution, this is an array of the warnings.
    /// </summary>
    /// <value>If the flow encountered a warning during execution, this is an array of the warnings.</value>
    public IEnumerable<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Warnings { get; set; }
}
