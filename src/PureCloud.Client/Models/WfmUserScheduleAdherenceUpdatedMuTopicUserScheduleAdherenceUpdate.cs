using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate
{
    /// <summary>
    /// Gets or Sets RoutingStatus
    /// </summary>
    public WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdateRoutingStatusEnum? RoutingStatus { get; set; }

    /// <summary>
    /// Gets or Sets AdherenceState
    /// </summary>
    public WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdateAdherenceStateEnum? AdherenceState { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public WfmUserScheduleAdherenceUpdatedMuTopicUserReference User { get; set; }

    /// <summary>
    /// Gets or Sets ManagementUnitId
    /// </summary>
    public string ManagementUnitId { get; set; }

    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    public WfmUserScheduleAdherenceUpdatedMuTopicUriReference Team { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledActivityCategory
    /// </summary>
    public string ScheduledActivityCategory { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledActivityCode
    /// </summary>
    public WfmUserScheduleAdherenceUpdatedMuTopicActivityCodeReference ScheduledActivityCode { get; set; }

    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    public string SystemPresence { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationSecondaryPresenceId
    /// </summary>
    public string OrganizationSecondaryPresenceId { get; set; }

    /// <summary>
    /// Gets or Sets ActualActivityCategory
    /// </summary>
    public string ActualActivityCategory { get; set; }

    /// <summary>
    /// Gets or Sets IsOutOfOffice
    /// </summary>
    public bool? IsOutOfOffice { get; set; }

    /// <summary>
    /// Gets or Sets Impact
    /// </summary>
    public string Impact { get; set; }

    /// <summary>
    /// Gets or Sets AdherenceExplanation
    /// </summary>
    public WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation AdherenceExplanation { get; set; }

    /// <summary>
    /// Gets or Sets AdherenceChangeTime
    /// </summary>
    public DateTime? AdherenceChangeTime { get; set; }

    /// <summary>
    /// Gets or Sets PresenceUpdateTime
    /// </summary>
    public DateTime? PresenceUpdateTime { get; set; }

    /// <summary>
    /// Gets or Sets ActiveQueues
    /// </summary>
    public IEnumerable<WfmUserScheduleAdherenceUpdatedMuTopicQueueReference> ActiveQueues { get; set; }

    /// <summary>
    /// Gets or Sets ActiveQueuesModifiedTime
    /// </summary>
    public DateTime? ActiveQueuesModifiedTime { get; set; }

    /// <summary>
    /// Gets or Sets RemovedFromManagementUnit
    /// </summary>
    public bool? RemovedFromManagementUnit { get; set; }

    /// <summary>
    /// Gets or Sets SuppressOnTimeReminder
    /// </summary>
    public bool? SuppressOnTimeReminder { get; set; }

    /// <summary>
    /// Gets or Sets NextActivityReminders
    /// </summary>
    public IEnumerable<WfmUserScheduleAdherenceUpdatedMuTopicUserNextActivityReminder> NextActivityReminders { get; set; }
}
