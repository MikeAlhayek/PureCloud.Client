using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo
{
    /// <summary>
    /// The reason a executionItem encountered an error or warning.
    /// </summary>
    /// <value>The reason a executionItem encountered an error or warning.</value>
    public string Reason { get; set; }

    /// <summary>
    /// If applicable, the executionId for the executionItem that invoked the error or warning.
    /// </summary>
    /// <value>If applicable, the executionId for the executionItem that invoked the error or warning.</value>
    public string ExecutionId { get; set; }

    /// <summary>
    /// If applicable, the objectId for the executionItem that invoked the error or warning.
    /// </summary>
    /// <value>If applicable, the objectId for the executionItem that invoked the error or warning.</value>
    public string ObjectId { get; set; }
}
