using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class V2MobiusAlertsTopicAlertSummaryEntity
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    public V2MobiusAlertsTopicAlertSummaryEntityEntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public V2MobiusAlertsTopicAlertingAddressableEntityRef User { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public V2MobiusAlertsTopicAlertingAddressableEntityRef Group { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    public V2MobiusAlertsTopicAlertingAddressableEntityRef Queue { get; set; }

    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    public V2MobiusAlertsTopicAlertingAddressableEntityRef Team { get; set; }

    /// <summary>
    /// Gets or Sets Alerting
    /// </summary>
    public bool? Alerting { get; set; }
}
