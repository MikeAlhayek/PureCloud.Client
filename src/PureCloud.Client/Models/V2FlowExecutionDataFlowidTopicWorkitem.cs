using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicWorkitem
{
    /// <summary>
    /// The identifier of the workitem that invoked this flow.
    /// </summary>
    /// <value>The identifier of the workitem that invoked this flow.</value>
    public string WorkitemId { get; set; }

    /// <summary>
    /// The name of the process workitem that invoked this flow.
    /// </summary>
    /// <value>The name of the process workitem that invoked this flow.</value>
    public string WorkitemName { get; set; }
}
