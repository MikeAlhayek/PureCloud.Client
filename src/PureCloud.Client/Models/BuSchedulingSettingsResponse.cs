namespace PureCloud.Client.Models;

/// <summary>
/// BuSchedulingSettingsResponse
/// </summary>
public sealed class BuSchedulingSettingsResponse
{
    /// <summary>
    /// The activity smoothing type for schedule generation in this business unit
    /// </summary>
    /// <value>The activity smoothing type for schedule generation in this business unit</value>
    public BuSchedulingSettingsRequestActivitySmoothingType ActivitySmoothingType { get; set; }

    /// <summary>
    /// Schedule generation message severity configuration
    /// </summary>
    /// <value>Schedule generation message severity configuration</value>
    public IEnumerable<SchedulerMessageTypeSeverity> MessageSeverities { get; set; }

    /// <summary>
    /// Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published.
    /// </summary>
    /// <value>Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published.</value>
    public IEnumerable<SetWrapperSyncTimeOffProperty> SyncTimeOffProperties { get; set; }

    /// <summary>
    /// Configures the max percent increase and decrease of service goals for this business unit
    /// </summary>
    /// <value>Configures the max percent increase and decrease of service goals for this business unit</value>
    public WfmServiceGoalImpactSettings ServiceGoalImpact { get; set; }

    /// <summary>
    /// Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false.
    /// </summary>
    /// <value>Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false.</value>
    public bool? AllowWorkPlanPerMinuteGranularity { get; set; }

    /// <summary>
    /// Indicates whether to provide variability in schedule generation
    /// </summary>
    /// <value>Indicates whether to provide variability in schedule generation</value>
    public bool? InduceScheduleVariability { get; set; }
}