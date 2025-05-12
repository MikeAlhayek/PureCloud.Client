using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicQuality
{
    /// <summary>
    /// The identifier of the quality policy that invoked this flow.
    /// </summary>
    /// <value>The identifier of the quality policy that invoked this flow.</value>
    public string PolicyId { get; set; }

    /// <summary>
    /// The name of the quality policy that invoked this flow.
    /// </summary>
    /// <value>The name of the quality policy that invoked this flow.</value>
    public string PolicyName { get; set; }
}
