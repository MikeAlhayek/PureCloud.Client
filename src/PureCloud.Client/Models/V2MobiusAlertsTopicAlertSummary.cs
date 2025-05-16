using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusAlertsTopicAlertSummary
{
    /// <summary>
    /// Gets or Sets MetricType
    /// </summary>
    public V2MobiusAlertsTopicAlertSummaryMetricTypeEnum? MetricType { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<V2MobiusAlertsTopicAlertSummaryEntity> Entities { get; set; }

    /// <summary>
    /// Gets or Sets Conversation
    /// </summary>
    public V2MobiusAlertsTopicAddressableEntityRef Conversation { get; set; }

    /// <summary>
    /// Gets or Sets IsTeamMemberRuleSummary
    /// </summary>
    public bool? IsTeamMemberRuleSummary { get; set; }

    /// <summary>
    /// Gets or Sets TeamMemberRuleSummary
    /// </summary>
    public bool? TeamMemberRuleSummary { get; set; }
}
