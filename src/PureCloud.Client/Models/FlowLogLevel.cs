using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowLogLevel
{
    /// <summary>
    /// The logLevel for this characteristics set
    /// </summary>
    /// <value>The logLevel for this characteristics set</value>
    public FlowLogLevelLevelEnum? Level { get; set; }

    /// <summary>
    /// Shows what characteristics are enabled for this log level
    /// </summary>
    /// <value>Shows what characteristics are enabled for this log level</value>
    public FlowCharacteristics Characteristics { get; set; }
}
