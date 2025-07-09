using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EmergencyCallFlow
{
    /// <summary>
    /// The call flow to execute in an emergency.
    /// </summary>
    /// <value>The call flow to execute in an emergency.</value>
    public DomainEntityRef EmergencyFlow { get; set; }

    /// <summary>
    /// The IVR(s) to route to the call flow during an emergency.
    /// </summary>
    /// <value>The IVR(s) to route to the call flow during an emergency.</value>
    public IEnumerable<DomainEntityRef> Ivrs { get; set; }
}
