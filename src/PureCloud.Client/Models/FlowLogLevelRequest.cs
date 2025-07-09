using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowLogLevelRequest
{
    /// <summary>
    /// The log level characteristics currently set for this flow
    /// </summary>
    /// <value>The log level characteristics currently set for this flow</value>
    public FlowLogLevel LogLevelCharacteristics { get; set; }
}
