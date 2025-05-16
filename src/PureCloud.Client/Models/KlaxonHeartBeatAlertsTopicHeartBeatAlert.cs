using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class KlaxonHeartBeatAlertsTopicHeartBeatAlert
{
    /// <summary>
    /// Gets or Sets RuleType
    /// </summary>
    public KlaxonHeartBeatAlertsTopicHeartBeatAlertRuleTypeEnum? RuleType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SenderId
    /// </summary>
    public string SenderId { get; set; }

    /// <summary>
    /// Gets or Sets HeartBeatTimeoutInMinutes
    /// </summary>
    public double? HeartBeatTimeoutInMinutes { get; set; }

    /// <summary>
    /// Gets or Sets RuleId
    /// </summary>
    public string RuleId { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets NotificationUsers
    /// </summary>
    public IEnumerable<KlaxonHeartBeatAlertsTopicNotificationUser> NotificationUsers { get; set; }

    /// <summary>
    /// Gets or Sets AlertTypes
    /// </summary>
    public IEnumerable<KlaxonHeartBeatAlertsTopicHeartBeatAlertAlertTypesEnum> AlertTypes { get; set; }
}
