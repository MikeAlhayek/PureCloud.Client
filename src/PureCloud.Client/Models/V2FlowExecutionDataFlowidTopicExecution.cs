using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicExecution
{
    /// <summary>
    /// The type of executionItem that was executed.
    /// </summary>
    /// <value>The type of executionItem that was executed.</value>
    public string ObjectType { get; set; }

    /// <summary>
    /// If applicable, the actionId, menuId or taskId for the executionItem.
    /// </summary>
    /// <value>If applicable, the actionId, menuId or taskId for the executionItem.</value>
    public string ObjectId { get; set; }

    /// <summary>
    /// If applicable, the identifier of the OutputPath that was taken.
    /// </summary>
    /// <value>If applicable, the identifier of the OutputPath that was taken.</value>
    public string OutputPathId { get; set; }

    /// <summary>
    /// If applicable, the executionId for the executionItem.
    /// </summary>
    /// <value>If applicable, the executionId for the executionItem.</value>
    public string ExecutionId { get; set; }

    /// <summary>
    /// This is the starting time of the executionItem.
    /// </summary>
    /// <value>This is the starting time of the executionItem.</value>
    public DateTime? StartDateTime { get; set; }

    /// <summary>
    /// Event generated when a Flow&#39;s Execution History is received and logged.
    /// </summary>
    /// <value>Event generated when a Flow&#39;s Execution History is received and logged.</value>
    public V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Error { get; set; }

    /// <summary>
    /// Event generated when a Flow&#39;s Execution History is received and logged.
    /// </summary>
    /// <value>Event generated when a Flow&#39;s Execution History is received and logged.</value>
    public V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Warning { get; set; }

    /// <summary>
    /// If applicable, the language tag associated set by the execution.
    /// </summary>
    /// <value>If applicable, the language tag associated set by the execution.</value>
    public string LanguageTag { get; set; }
}
