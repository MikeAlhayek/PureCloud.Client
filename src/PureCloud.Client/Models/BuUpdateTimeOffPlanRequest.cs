using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuUpdateTimeOffPlanRequest
/// </summary>

public partial class BuUpdateTimeOffPlanRequest : IEquatable<BuUpdateTimeOffPlanRequest>
{
    /// <summary>
    /// Auto approval rule for this time-off plan
    /// </summary>
    /// <value>Auto approval rule for this time-off plan</value>
    
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
    /// Auto approval rule for this time-off plan
    /// </summary>
    /// <value>Auto approval rule for this time-off plan</value>
    [JsonPropertyName("autoApprovalRule")]
    public AutoApprovalRuleEnum? AutoApprovalRule { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BuUpdateTimeOffPlanRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuUpdateTimeOffPlanRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuUpdateTimeOffPlanRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of this time-off plan.</param>
    /// <param name="ActivityCodeIds">The IDs of activity codes to associate with this time-off plan.</param>
    /// <param name="AutoApprovalRule">Auto approval rule for this time-off plan.</param>
    /// <param name="DaysBeforeStartToExpireFromWaitlist">The number of days before the time-off request start date for when the request will be expired from the waitlist.</param>
    /// <param name="HrisTimeOffType">Time-off type, if this time-off plan is associated with the integration.</param>
    /// <param name="Enabled">Whether this time-off plan should be used by agents.</param>
    /// <param name="CountAgainstTimeOffLimits">Whether this time-off plan should count against time-off limits.</param>
    /// <param name="BusinessUnitAssociation">Business unit association, if the time-off plan belongs to a business unit. managementUnitAssociation must not be set if this is populated.</param>
    /// <param name="ManagementUnitAssociation">Management unit association, if the time-off plan belongs to a management unit. businessUnitAssociation must not be set if this is populated.</param>
    /// <param name="Metadata">Version metadata for this time-off plan (required).</param>
    public BuUpdateTimeOffPlanRequest(string Name = null, SetWrapperString ActivityCodeIds = null, AutoApprovalRuleEnum? AutoApprovalRule = null, int? DaysBeforeStartToExpireFromWaitlist = null, ValueWrapperHrisTimeOffType HrisTimeOffType = null, bool? Enabled = null, bool? CountAgainstTimeOffLimits = null, UpdateTimeOffPlanBusinessUnitAssociation BusinessUnitAssociation = null, UpdateTimeOffPlanManagementUnitAssociation ManagementUnitAssociation = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.ActivityCodeIds = ActivityCodeIds;
        this.AutoApprovalRule = AutoApprovalRule;
        this.DaysBeforeStartToExpireFromWaitlist = DaysBeforeStartToExpireFromWaitlist;
        this.HrisTimeOffType = HrisTimeOffType;
        this.Enabled = Enabled;
        this.CountAgainstTimeOffLimits = CountAgainstTimeOffLimits;
        this.BusinessUnitAssociation = BusinessUnitAssociation;
        this.ManagementUnitAssociation = ManagementUnitAssociation;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The name of this time-off plan
    /// </summary>
    /// <value>The name of this time-off plan</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The IDs of activity codes to associate with this time-off plan
    /// </summary>
    /// <value>The IDs of activity codes to associate with this time-off plan</value>
    [JsonPropertyName("activityCodeIds")]
    public SetWrapperString ActivityCodeIds { get; set; }





    /// <summary>
    /// The number of days before the time-off request start date for when the request will be expired from the waitlist
    /// </summary>
    /// <value>The number of days before the time-off request start date for when the request will be expired from the waitlist</value>
    [JsonPropertyName("daysBeforeStartToExpireFromWaitlist")]
    public int? DaysBeforeStartToExpireFromWaitlist { get; set; }



    /// <summary>
    /// Time-off type, if this time-off plan is associated with the integration
    /// </summary>
    /// <value>Time-off type, if this time-off plan is associated with the integration</value>
    [JsonPropertyName("hrisTimeOffType")]
    public ValueWrapperHrisTimeOffType HrisTimeOffType { get; set; }



    /// <summary>
    /// Whether this time-off plan should be used by agents
    /// </summary>
    /// <value>Whether this time-off plan should be used by agents</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Whether this time-off plan should count against time-off limits
    /// </summary>
    /// <value>Whether this time-off plan should count against time-off limits</value>
    [JsonPropertyName("countAgainstTimeOffLimits")]
    public bool? CountAgainstTimeOffLimits { get; set; }



    /// <summary>
    /// Business unit association, if the time-off plan belongs to a business unit. managementUnitAssociation must not be set if this is populated
    /// </summary>
    /// <value>Business unit association, if the time-off plan belongs to a business unit. managementUnitAssociation must not be set if this is populated</value>
    [JsonPropertyName("businessUnitAssociation")]
    public UpdateTimeOffPlanBusinessUnitAssociation BusinessUnitAssociation { get; set; }



    /// <summary>
    /// Management unit association, if the time-off plan belongs to a management unit. businessUnitAssociation must not be set if this is populated
    /// </summary>
    /// <value>Management unit association, if the time-off plan belongs to a management unit. businessUnitAssociation must not be set if this is populated</value>
    [JsonPropertyName("managementUnitAssociation")]
    public UpdateTimeOffPlanManagementUnitAssociation ManagementUnitAssociation { get; set; }



    /// <summary>
    /// Version metadata for this time-off plan
    /// </summary>
    /// <value>Version metadata for this time-off plan</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuUpdateTimeOffPlanRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ActivityCodeIds: ").Append(ActivityCodeIds).Append("\n");
        sb.Append("  AutoApprovalRule: ").Append(AutoApprovalRule).Append("\n");
        sb.Append("  DaysBeforeStartToExpireFromWaitlist: ").Append(DaysBeforeStartToExpireFromWaitlist).Append("\n");
        sb.Append("  HrisTimeOffType: ").Append(HrisTimeOffType).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  CountAgainstTimeOffLimits: ").Append(CountAgainstTimeOffLimits).Append("\n");
        sb.Append("  BusinessUnitAssociation: ").Append(BusinessUnitAssociation).Append("\n");
        sb.Append("  ManagementUnitAssociation: ").Append(ManagementUnitAssociation).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as BuUpdateTimeOffPlanRequest);
    }

    /// <summary>
    /// Returns true if BuUpdateTimeOffPlanRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuUpdateTimeOffPlanRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuUpdateTimeOffPlanRequest other)
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
                ActivityCodeIds.Equals(other.ActivityCodeIds)
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                CountAgainstTimeOffLimits == other.CountAgainstTimeOffLimits ||
                CountAgainstTimeOffLimits != null &&
                CountAgainstTimeOffLimits.Equals(other.CountAgainstTimeOffLimits)
            ) &&
            (
                BusinessUnitAssociation == other.BusinessUnitAssociation ||
                BusinessUnitAssociation != null &&
                BusinessUnitAssociation.Equals(other.BusinessUnitAssociation)
            ) &&
            (
                ManagementUnitAssociation == other.ManagementUnitAssociation ||
                ManagementUnitAssociation != null &&
                ManagementUnitAssociation.Equals(other.ManagementUnitAssociation)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (CountAgainstTimeOffLimits != null)
            {
                hash = hash * 59 + CountAgainstTimeOffLimits.GetHashCode();
            }

            if (BusinessUnitAssociation != null)
            {
                hash = hash * 59 + BusinessUnitAssociation.GetHashCode();
            }

            if (ManagementUnitAssociation != null)
            {
                hash = hash * 59 + ManagementUnitAssociation.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
