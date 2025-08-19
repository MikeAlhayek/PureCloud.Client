namespace PureCloud.Client.Models;

/// <summary>
/// CreateActivityPlanRequest
/// </summary>
public sealed class CreateActivityPlanRequest
{
    /// <summary>
    /// CreateActivityPlanRequest
    /// </summary>
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// The optimization objective of this activity plan
    /// </summary>
    public OptimizationObjectiveEnum? OptimizationObjective { get; set; }

    /// <summary>
    /// The state of this activity plan
    /// </summary>
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateActivityPlanRequest" /> class.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The management units to which this activity plan applies. Empty list or null means this activity plan applies to the entire business unit
    /// </summary>
    public IEnumerable<string> ManagementUnitIds { get; set; }

    /// <summary>
    /// The description of the activity plan
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The activity code associated with the activity plan
    /// </summary>
    public string? ActivityCodeId { get; set; }

    /// <summary>
    /// The length in minutes of the activity plan
    /// </summary>
    public int? LengthMinutes { get; set; }

    /// <summary>
    /// The initial scheduling period for the activity plan
    /// </summary>
    public SchedulingPeriod? InitialSchedulePeriod { get; set; }

    /// <summary>
    /// Group settings for the activity plan
    /// </summary>
    public GroupSettings? GroupSettings { get; set; }

    /// <summary>
    /// Settings controlling recurrence for the activity plan. If not set the activity plan will only occur once
    /// </summary>
    public RecurrenceSettings? RecurrenceSettings { get; set; }

    /// <summary>
    /// Attendee search rule for this activity plan
    /// </summary>
    public UserSearchRule? AttendeesSearchRule { get; set; }

    /// <summary>
    /// Whether the sessions created by this activity plan should be facilitated
    /// </summary>
    public bool? Facilitated { get; set; }

    /// <summary>
    /// Facilitator search rule for this activity plan
    /// </summary>
    public UserSearchRule? FacilitatorsSearchRule { get; set; }

    /// <summary>
    /// Transition time in minutes between facilitated sessions
    /// </summary>
    public int? TransitionTimeMinutes { get; set; }

    /// <summary>
    /// Allowable service goal impact override settings for this activity plan. If not set the business unit setting will be used
    /// </summary>
    public ActivityPlanServiceGoalImpactOverrides? ServiceGoalImpactOverrides { get; set; }

    /// <summary>
    /// Whether the activity should count as paid time
    /// </summary>
    public bool? CountsAsPaidTime { get; set; }

    /// <summary>
    /// Fixed availability configuration for the activity plan
    /// </summary>
    public IEnumerable<FixedAvailability> FixedAvailability { get; set; }
}
