using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuSchedulingSettingsRequest
/// </summary>

public partial class BuSchedulingSettingsRequest : IEquatable<BuSchedulingSettingsRequest>
{
    /// <summary>
    /// The activity smoothing type for schedule generation in this business unit
    /// </summary>
    /// <value>The activity smoothing type for schedule generation in this business unit</value>
    
    public enum ActivitySmoothingTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Reduceconcurrentactivitiesacrossbu for "ReduceConcurrentActivitiesAcrossBu"
        /// </summary>
        [EnumMember(Value = "ReduceConcurrentActivitiesAcrossBu")]
        Reduceconcurrentactivitiesacrossbu,

        /// <summary>
        /// Enum Reduceconcurrentactivitiesacrossmu for "ReduceConcurrentActivitiesAcrossMu"
        /// </summary>
        [EnumMember(Value = "ReduceConcurrentActivitiesAcrossMu")]
        Reduceconcurrentactivitiesacrossmu,

        /// <summary>
        /// Enum Consistentservicelevel for "ConsistentServiceLevel"
        /// </summary>
        [EnumMember(Value = "ConsistentServiceLevel")]
        Consistentservicelevel
    }
    /// <summary>
    /// The activity smoothing type for schedule generation in this business unit
    /// </summary>
    /// <value>The activity smoothing type for schedule generation in this business unit</value>
    [JsonPropertyName("activitySmoothingType")]
    public ActivitySmoothingTypeEnum? ActivitySmoothingType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuSchedulingSettingsRequest" /> class.
    /// </summary>
    /// <param name="MessageSeverities">Schedule generation message severity configuration.</param>
    /// <param name="SyncTimeOffProperties">Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published..</param>
    /// <param name="ServiceGoalImpact">Configures the max percent increase and decrease of service goals for this business unit.</param>
    /// <param name="AllowWorkPlanPerMinuteGranularity">Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false..</param>
    /// <param name="ActivitySmoothingType">The activity smoothing type for schedule generation in this business unit.</param>
    /// <param name="InduceScheduleVariability">Indicates whether to provide variability in schedule generation.</param>
    public BuSchedulingSettingsRequest(List<SchedulerMessageTypeSeverity> MessageSeverities = null, SetWrapperSyncTimeOffProperty SyncTimeOffProperties = null, WfmServiceGoalImpactSettings ServiceGoalImpact = null, bool? AllowWorkPlanPerMinuteGranularity = null, ActivitySmoothingTypeEnum? ActivitySmoothingType = null, bool? InduceScheduleVariability = null)
    {
        this.MessageSeverities = MessageSeverities;
        this.SyncTimeOffProperties = SyncTimeOffProperties;
        this.ServiceGoalImpact = ServiceGoalImpact;
        this.AllowWorkPlanPerMinuteGranularity = AllowWorkPlanPerMinuteGranularity;
        this.ActivitySmoothingType = ActivitySmoothingType;
        this.InduceScheduleVariability = InduceScheduleVariability;

    }



    /// <summary>
    /// Schedule generation message severity configuration
    /// </summary>
    /// <value>Schedule generation message severity configuration</value>
    [JsonPropertyName("messageSeverities")]
    public List<SchedulerMessageTypeSeverity> MessageSeverities { get; set; }



    /// <summary>
    /// Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published.
    /// </summary>
    /// <value>Synchronize set of time off properties from scheduled activities to time off requests when the schedule is published.</value>
    [JsonPropertyName("syncTimeOffProperties")]
    public SetWrapperSyncTimeOffProperty SyncTimeOffProperties { get; set; }



    /// <summary>
    /// Configures the max percent increase and decrease of service goals for this business unit
    /// </summary>
    /// <value>Configures the max percent increase and decrease of service goals for this business unit</value>
    [JsonPropertyName("serviceGoalImpact")]
    public WfmServiceGoalImpactSettings ServiceGoalImpact { get; set; }



    /// <summary>
    /// Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false.
    /// </summary>
    /// <value>Indicates whether or not per minute granularity for scheduling will be enabled for this business unit. Defaults to false.</value>
    [JsonPropertyName("allowWorkPlanPerMinuteGranularity")]
    public bool? AllowWorkPlanPerMinuteGranularity { get; set; }





    /// <summary>
    /// Indicates whether to provide variability in schedule generation
    /// </summary>
    /// <value>Indicates whether to provide variability in schedule generation</value>
    [JsonPropertyName("induceScheduleVariability")]
    public bool? InduceScheduleVariability { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuSchedulingSettingsRequest {\n");

        sb.Append("  MessageSeverities: ").Append(MessageSeverities).Append("\n");
        sb.Append("  SyncTimeOffProperties: ").Append(SyncTimeOffProperties).Append("\n");
        sb.Append("  ServiceGoalImpact: ").Append(ServiceGoalImpact).Append("\n");
        sb.Append("  AllowWorkPlanPerMinuteGranularity: ").Append(AllowWorkPlanPerMinuteGranularity).Append("\n");
        sb.Append("  ActivitySmoothingType: ").Append(ActivitySmoothingType).Append("\n");
        sb.Append("  InduceScheduleVariability: ").Append(InduceScheduleVariability).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as BuSchedulingSettingsRequest);
    }

    /// <summary>
    /// Returns true if BuSchedulingSettingsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuSchedulingSettingsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuSchedulingSettingsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MessageSeverities == other.MessageSeverities ||
                MessageSeverities != null &&
                MessageSeverities.SequenceEqual(other.MessageSeverities)
            ) &&
            (
                SyncTimeOffProperties == other.SyncTimeOffProperties ||
                SyncTimeOffProperties != null &&
                SyncTimeOffProperties.Equals(other.SyncTimeOffProperties)
            ) &&
            (
                ServiceGoalImpact == other.ServiceGoalImpact ||
                ServiceGoalImpact != null &&
                ServiceGoalImpact.Equals(other.ServiceGoalImpact)
            ) &&
            (
                AllowWorkPlanPerMinuteGranularity == other.AllowWorkPlanPerMinuteGranularity ||
                AllowWorkPlanPerMinuteGranularity != null &&
                AllowWorkPlanPerMinuteGranularity.Equals(other.AllowWorkPlanPerMinuteGranularity)
            ) &&
            (
                ActivitySmoothingType == other.ActivitySmoothingType ||
                ActivitySmoothingType != null &&
                ActivitySmoothingType.Equals(other.ActivitySmoothingType)
            ) &&
            (
                InduceScheduleVariability == other.InduceScheduleVariability ||
                InduceScheduleVariability != null &&
                InduceScheduleVariability.Equals(other.InduceScheduleVariability)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (MessageSeverities != null)
            {
                hash = hash * 59 + MessageSeverities.GetHashCode();
            }

            if (SyncTimeOffProperties != null)
            {
                hash = hash * 59 + SyncTimeOffProperties.GetHashCode();
            }

            if (ServiceGoalImpact != null)
            {
                hash = hash * 59 + ServiceGoalImpact.GetHashCode();
            }

            if (AllowWorkPlanPerMinuteGranularity != null)
            {
                hash = hash * 59 + AllowWorkPlanPerMinuteGranularity.GetHashCode();
            }

            if (ActivitySmoothingType != null)
            {
                hash = hash * 59 + ActivitySmoothingType.GetHashCode();
            }

            if (InduceScheduleVariability != null)
            {
                hash = hash * 59 + InduceScheduleVariability.GetHashCode();
            }

            return hash;
        }
    }
}
