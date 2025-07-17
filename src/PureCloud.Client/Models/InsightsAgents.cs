using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class InsightsAgents
{
    /// <summary>
    /// Granularity
    /// </summary>
    /// <value>Granularity</value>
    public InsightsAgentsGranularityEnum? Granularity { get; set; }

    /// <summary>
    /// The performance profile
    /// </summary>
    /// <value>The performance profile</value>
    public AddressableEntityRef PerformanceProfile { get; set; }

    /// <summary>
    /// The division
    /// </summary>
    /// <value>The division</value>
    public DivisionReference Division { get; set; }

    /// <summary>
    /// Start workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    public string DateStartWorkday { get; set; }

    /// <summary>
    /// End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End workday used as the date range. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    public string DateEndWorkday { get; set; }

    /// <summary>
    /// The list of insights agents
    /// </summary>
    /// <value>The list of insights agents</value>
    public IEnumerable<InsightsAgentItem> Entities { get; set; }
}
