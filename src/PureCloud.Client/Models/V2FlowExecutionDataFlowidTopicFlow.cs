using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2FlowExecutionDataFlowidTopicFlow
{
    /// <summary>
    /// The flow execution identifier whose runtime that invoked this.
    /// </summary>
    /// <value>The flow execution identifier whose runtime that invoked this.</value>
    public string FlowExecutionId { get; set; }

    /// <summary>
    /// The object execution identifier within the flow whose runtime that invoked this.  In Architect flows, this object execution identifier will be either an action execution identifier or a menu execution identifier.
    /// </summary>
    /// <value>The object execution identifier within the flow whose runtime that invoked this.  In Architect flows, this object execution identifier will be either an action execution identifier or a menu execution identifier.</value>
    public string ObjectExecutionId { get; set; }
}
