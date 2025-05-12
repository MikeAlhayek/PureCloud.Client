using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicJourneyActionMap
{
    /// <summary>
    /// The identifier of the journey action map that invoked this flow.
    /// </summary>
    /// <value>The identifier of the journey action map that invoked this flow.</value>
    public string ActionMapId { get; set; }

    /// <summary>
    /// The identifier of the specific action map instance that invoked this flow.
    /// </summary>
    /// <value>The identifier of the specific action map instance that invoked this flow.</value>
    public string ActionId { get; set; }
}
