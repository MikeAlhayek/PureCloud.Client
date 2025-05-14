using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicProcessAutomation
{
    /// <summary>
    /// The identifier of the process automation trigger that invoked this flow.
    /// </summary>
    /// <value>The identifier of the process automation trigger that invoked this flow.</value>
    public string TriggerId { get; set; }

    /// <summary>
    /// The name of the process automation trigger that invoked this flow.
    /// </summary>
    /// <value>The name of the process automation trigger that invoked this flow.</value>
    public string TriggerName { get; set; }
}
