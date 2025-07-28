using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActivityCode
/// </summary>
public sealed class ActivityCode
{
    /// <summary>
    /// The activity code's category.
    /// </summary>
    /// <value>The activity code's category.</value>
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
    /// The activity code's category.
    /// </summary>
    /// <value>The activity code's category.</value>
    public CategoryEnum? Category { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// The name of the activity code. Default activity codes will be created with an empty name
    /// </summary>
    /// <value>The name of the activity code. Default activity codes will be created with an empty name</value>
    public string Name { get; set; }

    /// <summary>
    /// Whether this activity code is active or has been deleted
    /// </summary>
    /// <value>Whether this activity code is active or has been deleted</value>
    public bool? IsActive { get; set; }

    /// <summary>
    /// Whether this is a default activity code
    /// </summary>
    /// <value>Whether this is a default activity code</value>
    public bool? IsDefault { get; set; }

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
    /// Version metadata for the associated management unit's list of activity codes
    /// </summary>
    /// <value>Version metadata for the associated management unit's list of activity codes</value>
    public WfmVersionedEntityMetadata Metadata { get; set; }
}