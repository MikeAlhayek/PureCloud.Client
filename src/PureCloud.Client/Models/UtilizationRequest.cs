using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UtilizationRequest
{
    /// <summary>
    /// Map of media type to utilization settings.
    /// </summary>
    /// <value>Map of media type to utilization settings.</value>
    public Dictionary<string, MediaUtilization> Utilization { get; set; }

    /// <summary>
    /// Map of label ids to utilization settings.
    /// </summary>
    /// <value>Map of label ids to utilization settings.</value>
    public Dictionary<string, LabelUtilizationRequest> LabelUtilizations { get; set; }
}
