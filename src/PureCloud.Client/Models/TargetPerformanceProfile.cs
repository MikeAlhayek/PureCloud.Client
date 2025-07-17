using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TargetPerformanceProfile
{
    /// <summary>
    /// The target destination performanceProfileId for the linked metric.
    /// </summary>
    /// <value>The target destination performanceProfileId for the linked metric.</value>
    public string TargetPerformanceProfileId { get; set; }
}
