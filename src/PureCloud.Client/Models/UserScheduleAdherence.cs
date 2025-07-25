namespace PureCloud.Client.Models;

/// <summary>
/// UserScheduleAdherence
/// </summary>
public sealed class UserScheduleAdherence
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The user for whom this status applies
    /// </summary>
    public UserReference User { get; set; }

    /// <summary>
    /// The business unit to which this user belongs
    /// </summary>
    public BusinessUnitReference BusinessUnit { get; set; }

    /// <summary>
    /// The management unit to which this user belongs
    /// </summary>
    public ManagementUnitReference ManagementUnit { get; set; }

    /// <summary>
    /// The team to which this user belongs
    /// </summary>
    public TeamReference Team { get; set; }

    /// <summary>
    /// Activity for which the user is scheduled
    /// </summary>
    public ScheduledActivityCategory ScheduledActivityCategory { get; set; }

    /// <summary>
    /// Activity code for which the user is currently scheduled
    /// </summary>
    public ActivityCodeSummary ScheduledActivityCode { get; set; }

    /// <summary>
    /// Actual underlying system presence value
    /// </summary>
    public SystemPresence SystemPresence { get; set; }

    /// <summary>
    /// Organization Secondary Presence Id.
    /// </summary>
    public string OrganizationSecondaryPresenceId { get; set; }

    /// <summary>
    /// Actual underlying routing status, used to determine whether a user is actually in adherence when OnQueue
    /// </summary>
    public UserScheduleRoutingStatus RoutingStatus { get; set; }

    /// <summary>
    /// Activity in which the user is actually engaged
    /// </summary>
    public ActualActivityCategory ActualActivityCategory { get; set; }

    /// <summary>
    /// Whether the user is marked OutOfOffice
    /// </summary>
    public bool? IsOutOfOffice { get; set; }

    /// <summary>
    /// The user's current adherence state
    /// </summary>
    public AdherenceState AdherenceState { get; set; }

    /// <summary>
    /// The impact of the user's current adherenceState
    /// </summary>
    public Impact Impact { get; set; }

    /// <summary>
    /// Currently applicable explanation for the adherence state
    /// </summary>
    public RealTimeAdherenceExplanation AdherenceExplanation { get; set; }

    /// <summary>
    /// Time when the user entered the current adherenceState in ISO-8601 format
    /// </summary>
    public DateTime? TimeOfAdherenceChange { get; set; }

    /// <summary>
    /// Time when presence was last updated. Used to calculate time in current status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? PresenceUpdateTime { get; set; }

    /// <summary>
    /// The list of queues to which this user is joined
    /// </summary>
    public IEnumerable<QueueReference> ActiveQueues { get; set; }

    /// <summary>
    /// Time when the list of active queues for this user was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    public DateTime? ActiveQueuesModifiedTime { get; set; }

    /// <summary>
    /// For notification purposes. Used to indicate that a user was removed from the management unit
    /// </summary>
    public bool? RemovedFromManagementUnit { get; set; }

    /// <summary>
    /// A list of upcoming activities for which the user is scheduled
    /// </summary>
    public IEnumerable<UserNextActivityReminder> NextActivityReminders { get; set; }

    /// <summary>
    /// Indicates whether the on-time adherence notification should be suppressed for the user
    /// </summary>
    public bool? SuppressOnTimeReminder { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}
