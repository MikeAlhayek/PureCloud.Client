using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateTimeOffPlanRequest
/// </summary>

public partial class CreateTimeOffPlanRequest : IEquatable<CreateTimeOffPlanRequest>
{
    /// <summary>
    /// Auto approval rule for the time off plan.
    /// </summary>
    /// <value>Auto approval rule for the time off plan.</value>
    
    public enum AutoApprovalRuleEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Never for "Never"
        /// </summary>
        [EnumMember(Value = "Never")]
        Never,

        /// <summary>
        /// Enum Always for "Always"
        /// </summary>
        [EnumMember(Value = "Always")]
        Always,

        /// <summary>
        /// Enum Checklimits for "CheckLimits"
        /// </summary>
        [EnumMember(Value = "CheckLimits")]
        Checklimits,

        /// <summary>
        /// Enum Checkactivitycodes for "CheckActivityCodes"
        /// </summary>
        [EnumMember(Value = "CheckActivityCodes")]
        Checkactivitycodes,

        /// <summary>
        /// Enum Checklimitsandactivitycodes for "CheckLimitsAndActivityCodes"
        /// </summary>
        [EnumMember(Value = "CheckLimitsAndActivityCodes")]
        Checklimitsandactivitycodes
    }
    /// <summary>
    /// Auto approval rule for the time off plan.
    /// </summary>
    /// <value>Auto approval rule for the time off plan.</value>
    [JsonPropertyName("autoApprovalRule")]
    public AutoApprovalRuleEnum? AutoApprovalRule { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTimeOffPlanRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateTimeOffPlanRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTimeOffPlanRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of this time off plan. (required).</param>
    /// <param name="ActivityCodeIds">The set of activity code IDs to associate with this time off plan..</param>
    /// <param name="TimeOffLimitIds">The set of time off limit IDs to associate with this time off plan..</param>
    /// <param name="AutoApprovalRule">Auto approval rule for the time off plan. (required).</param>
    /// <param name="DaysBeforeStartToExpireFromWaitlist">The number of days before the time off request start date for when the request will be expired from the waitlist..</param>
    /// <param name="HrisTimeOffType">Time off type, if this time off plan is associated with the integration..</param>
    /// <param name="Active">Whether this time off plan should be used by agents. (required).</param>
    public CreateTimeOffPlanRequest(string Name = null, List<string> ActivityCodeIds = null, List<string> TimeOffLimitIds = null, AutoApprovalRuleEnum? AutoApprovalRule = null, int? DaysBeforeStartToExpireFromWaitlist = null, HrisTimeOffType HrisTimeOffType = null, bool? Active = null)
    {
        this.Name = Name;
        this.ActivityCodeIds = ActivityCodeIds;
        this.TimeOffLimitIds = TimeOffLimitIds;
        this.AutoApprovalRule = AutoApprovalRule;
        this.DaysBeforeStartToExpireFromWaitlist = DaysBeforeStartToExpireFromWaitlist;
        this.HrisTimeOffType = HrisTimeOffType;
        this.Active = Active;

    }



    /// <summary>
    /// The name of this time off plan.
    /// </summary>
    /// <value>The name of this time off plan.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The set of activity code IDs to associate with this time off plan.
    /// </summary>
    /// <value>The set of activity code IDs to associate with this time off plan.</value>
    [JsonPropertyName("activityCodeIds")]
    public List<string> ActivityCodeIds { get; set; }



    /// <summary>
    /// The set of time off limit IDs to associate with this time off plan.
    /// </summary>
    /// <value>The set of time off limit IDs to associate with this time off plan.</value>
    [JsonPropertyName("timeOffLimitIds")]
    public List<string> TimeOffLimitIds { get; set; }





    /// <summary>
    /// The number of days before the time off request start date for when the request will be expired from the waitlist.
    /// </summary>
    /// <value>The number of days before the time off request start date for when the request will be expired from the waitlist.</value>
    [JsonPropertyName("daysBeforeStartToExpireFromWaitlist")]
    public int? DaysBeforeStartToExpireFromWaitlist { get; set; }



    /// <summary>
    /// Time off type, if this time off plan is associated with the integration.
    /// </summary>
    /// <value>Time off type, if this time off plan is associated with the integration.</value>
    [JsonPropertyName("hrisTimeOffType")]
    public HrisTimeOffType HrisTimeOffType { get; set; }



    /// <summary>
    /// Whether this time off plan should be used by agents.
    /// </summary>
    /// <value>Whether this time off plan should be used by agents.</value>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateTimeOffPlanRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
        sb.Append("  TimeOffLimitIds: ").Append(TimeOffLimitIds).Append("\n");
        sb.Append("  AutoApprovalRule: ").Append(AutoApprovalRule).Append("\n");
        sb.Append("  DaysBeforeStartToExpireFromWaitlist: ").Append(DaysBeforeStartToExpireFromWaitlist).Append("\n");
        sb.Append("  HrisTimeOffType: ").Append(HrisTimeOffType).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
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
        return Equals(obj as CreateTimeOffPlanRequest);
    }

    /// <summary>
    /// Returns true if CreateTimeOffPlanRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateTimeOffPlanRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateTimeOffPlanRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ActivityCodeIds == other.ActivityCodeIds ||
                ActivityCodeIds != null &&
                ActivityCodeIds.SequenceEqual(other.ActivityCodeIds)
            ) &&
            (
                TimeOffLimitIds == other.TimeOffLimitIds ||
                TimeOffLimitIds != null &&
                TimeOffLimitIds.SequenceEqual(other.TimeOffLimitIds)
            ) &&
            (
                AutoApprovalRule == other.AutoApprovalRule ||
                AutoApprovalRule != null &&
                AutoApprovalRule.Equals(other.AutoApprovalRule)
            ) &&
            (
                DaysBeforeStartToExpireFromWaitlist == other.DaysBeforeStartToExpireFromWaitlist ||
                DaysBeforeStartToExpireFromWaitlist != null &&
                DaysBeforeStartToExpireFromWaitlist.Equals(other.DaysBeforeStartToExpireFromWaitlist)
            ) &&
            (
                HrisTimeOffType == other.HrisTimeOffType ||
                HrisTimeOffType != null &&
                HrisTimeOffType.Equals(other.HrisTimeOffType)
            ) &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ActivityCodeIds != null)
            {
                hash = hash * 59 + ActivityCodeIds.GetHashCode();
            }

            if (TimeOffLimitIds != null)
            {
                hash = hash * 59 + TimeOffLimitIds.GetHashCode();
            }

            if (AutoApprovalRule != null)
            {
                hash = hash * 59 + AutoApprovalRule.GetHashCode();
            }

            if (DaysBeforeStartToExpireFromWaitlist != null)
            {
                hash = hash * 59 + DaysBeforeStartToExpireFromWaitlist.GetHashCode();
            }

            if (HrisTimeOffType != null)
            {
                hash = hash * 59 + HrisTimeOffType.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            return hash;
        }
    }
}
