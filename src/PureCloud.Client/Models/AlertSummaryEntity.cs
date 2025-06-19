using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AlertSummaryEntity
{
    /// <summary>
    /// Specifies the type of entity being evaluated
    /// </summary>
    /// <value>Specifies the type of entity being evaluated</value>
    public AlertSummaryEntityEntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// User id of the entity being monitored
    /// </summary>
    /// <value>User id of the entity being monitored</value>
    public AddressableEntityRef User { get; set; }

    /// <summary>
    /// Group id of the entity being monitored
    /// </summary>
    /// <value>Group id of the entity being monitored</value>
    public AddressableEntityRef Group { get; set; }

    /// <summary>
    /// Queue id of the entity being monitored
    /// </summary>
    /// <value>Queue id of the entity being monitored</value>
    public AddressableEntityRef Queue { get; set; }

    /// <summary>
    /// Team id of the entity being monitored
    /// </summary>
    /// <value>Team id of the entity being monitored</value>
    public AddressableEntityRef Team { get; set; }

    /// <summary>
    /// Flag that indicated if the entity is current causing the alert to be triggered
    /// </summary>
    /// <value>Flag that indicated if the entity is current causing the alert to be triggered</value>
    public bool? Alerting { get; set; }
}
