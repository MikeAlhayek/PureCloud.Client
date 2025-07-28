using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateActivityCodeRequest
/// </summary>
public sealed class CreateActivityCodeRequest
{
    /// <summary>
    /// The activity code's category
    /// </summary>
    /// <value>The activity code's category</value>
    public enum CategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Onqueuework for "OnQueueWork"
        /// </summary>
        [EnumMember(Value = "OnQueueWork")]
        Onqueuework,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Offqueuework for "OffQueueWork"
        /// </summary>
        [EnumMember(Value = "OffQueueWork")]
        Offqueuework,

        /// <summary>
        /// Enum Timeoff for "TimeOff"
        /// </summary>
        [EnumMember(Value = "TimeOff")]
        Timeoff,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,

        /// <summary>
        /// Enum Unscheduled for "Unscheduled"
        /// </summary>
        [EnumMember(Value = "Unscheduled")]
        Unscheduled
    }

    /// <summary>
    /// The activity code's category
    /// </summary>
    /// <value>The activity code's category</value>
    public CategoryEnum? Category { get; set; }

    /// <summary>
    /// The name of the activity code
    /// </summary>
    /// <value>The name of the activity code</value>
    public string Name { get; set; }

    /// <summary>
    /// The default length of the activity in minutes
    /// </summary>
    /// <value>The default length of the activity in minutes</value>
    public int? LengthInMinutes { get; set; }

    /// <summary>
    /// Whether an agent is paid while performing this activity
    /// </summary>
    /// <value>Whether an agent is paid while performing this activity</value>
    public bool? CountsAsPaidTime { get; set; }

    /// <summary>
    /// Indicates whether or not the activity should be counted as work time
    /// </summary>
    /// <value>Indicates whether or not the activity should be counted as work time</value>
    public bool? CountsAsWorkTime { get; set; }

    /// <summary>
    /// Whether an agent can select this activity code when creating or editing a time off request
    /// </summary>
    /// <value>Whether an agent can select this activity code when creating or editing a time off request</value>
    public bool? AgentTimeOffSelectable { get; set; }

    /// <summary>
    /// Whether or not this activity code counts toward shrinkage calculations
    /// </summary>
    /// <value>Whether or not this activity code counts toward shrinkage calculations</value>
    public bool? CountsTowardShrinkage { get; set; }

    /// <summary>
    /// Whether this activity code is considered planned shrinkage
    /// </summary>
    /// <value>Whether this activity code is considered planned shrinkage</value>
    public bool? PlannedShrinkage { get; set; }

    /// <summary>
    /// Whether this activity code is considered interruptible
    /// </summary>
    /// <value>Whether this activity code is considered interruptible</value>
    public bool? Interruptible { get; set; }

    /// <summary>
    /// List of secondary presences allowed to be set for this activity code
    /// </summary>
    /// <value>List of secondary presences allowed to be set for this activity code</value>
    public List<SecondaryPresence> SecondaryPresences { get; set; }
}