using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CallForwardingEventCall
{
    /// <summary>
    /// Gets or Sets Targets
    /// </summary>
    public IEnumerable<CallForwardingEventTarget> Targets { get; set; }
}
