using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AlertSummary
{
    /// <summary>
    /// The metric type that is monitored.
    /// </summary>
    /// <value>The metric type that is monitored.</value>
    public AlertSummaryMetricTypeEnum? MetricType { get; set; }

    /// <summary>
    /// The entities who violated the rule condition over the duration of the alert.
    /// </summary>
    /// <value>The entities who violated the rule condition over the duration of the alert.</value>
    public IEnumerable<AlertSummaryEntity> Entities { get; set; }

    /// <summary>
    /// The id of the conversation that triggered the alert.  Only used for alerts based on instance-based conversation metrics.
    /// </summary>
    public AddressableEntityRef Conversation { get; set; }

    /// <summary>
    /// Flag that indicated whether or not the alert is for a rule with a condition for all members of a team.
    /// </summary>
    /// <value>Flag that indicated whether or not the alert is for a rule with a condition for all members of a team.</value>
    public bool? EntitiesAreTeamMembers { get; set; }
}
