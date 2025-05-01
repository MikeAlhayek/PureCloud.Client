using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ShiftTradeSettings
/// </summary>
[DataContract]
public partial class ShiftTradeSettings : IEquatable<ShiftTradeSettings>
{
    /// <summary>
    /// How to handle shift trades which involve unequal paid times
    /// </summary>
    /// <value>How to handle shift trades which involve unequal paid times</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnequalPaidEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Allow for "Allow"
        /// </summary>
        [EnumMember(Value = "Allow")]
        Allow,

        /// <summary>
        /// Enum Disallow for "Disallow"
        /// </summary>
        [EnumMember(Value = "Disallow")]
        Disallow,

        /// <summary>
        /// Enum Adminreview for "AdminReview"
        /// </summary>
        [EnumMember(Value = "AdminReview")]
        Adminreview
    }
    /// <summary>
    /// How to handle one-sided shift trades
    /// </summary>
    /// <value>How to handle one-sided shift trades</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OneSidedEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Allow for "Allow"
        /// </summary>
        [EnumMember(Value = "Allow")]
        Allow,

        /// <summary>
        /// Enum Disallow for "Disallow"
        /// </summary>
        [EnumMember(Value = "Disallow")]
        Disallow,

        /// <summary>
        /// Enum Adminreview for "AdminReview"
        /// </summary>
        [EnumMember(Value = "AdminReview")]
        Adminreview
    }
    /// <summary>
    /// How to handle shift trades which result in violations of weekly minimum paid time constraint
    /// </summary>
    /// <value>How to handle shift trades which result in violations of weekly minimum paid time constraint</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WeeklyMinPaidViolationsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Allow for "Allow"
        /// </summary>
        [EnumMember(Value = "Allow")]
        Allow,

        /// <summary>
        /// Enum Disallow for "Disallow"
        /// </summary>
        [EnumMember(Value = "Disallow")]
        Disallow,

        /// <summary>
        /// Enum Adminreview for "AdminReview"
        /// </summary>
        [EnumMember(Value = "AdminReview")]
        Adminreview
    }
    /// <summary>
    /// How to handle shift trades which result in violations of weekly maximum paid time constraint
    /// </summary>
    /// <value>How to handle shift trades which result in violations of weekly maximum paid time constraint</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WeeklyMaxPaidViolationsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Allow for "Allow"
        /// </summary>
        [EnumMember(Value = "Allow")]
        Allow,

        /// <summary>
        /// Enum Disallow for "Disallow"
        /// </summary>
        [EnumMember(Value = "Disallow")]
        Disallow,

        /// <summary>
        /// Enum Adminreview for "AdminReview"
        /// </summary>
        [EnumMember(Value = "AdminReview")]
        Adminreview
    }
    /// <summary>
    /// How to handle shift trades which involve unequal paid times
    /// </summary>
    /// <value>How to handle shift trades which involve unequal paid times</value>
    [DataMember(Name = "unequalPaid", EmitDefaultValue = false)]
    public UnequalPaidEnum? UnequalPaid { get; set; }
    /// <summary>
    /// How to handle one-sided shift trades
    /// </summary>
    /// <value>How to handle one-sided shift trades</value>
    [DataMember(Name = "oneSided", EmitDefaultValue = false)]
    public OneSidedEnum? OneSided { get; set; }
    /// <summary>
    /// How to handle shift trades which result in violations of weekly minimum paid time constraint
    /// </summary>
    /// <value>How to handle shift trades which result in violations of weekly minimum paid time constraint</value>
    [DataMember(Name = "weeklyMinPaidViolations", EmitDefaultValue = false)]
    public WeeklyMinPaidViolationsEnum? WeeklyMinPaidViolations { get; set; }
    /// <summary>
    /// How to handle shift trades which result in violations of weekly maximum paid time constraint
    /// </summary>
    /// <value>How to handle shift trades which result in violations of weekly maximum paid time constraint</value>
    [DataMember(Name = "weeklyMaxPaidViolations", EmitDefaultValue = false)]
    public WeeklyMaxPaidViolationsEnum? WeeklyMaxPaidViolations { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftTradeSettings" /> class.
    /// </summary>
    /// <param name="Enabled">Whether shift trading is enabled for this management unit.</param>
    /// <param name="AutoReview">Whether automatic shift trade review is enabled according to the rules defined in for this management unit.</param>
    /// <param name="AllowDirectTrades">Whether direct shift trades between agents are allowed.</param>
    /// <param name="MinHoursInFuture">The minimum number of hours in the future shift trades are allowed.</param>
    /// <param name="UnequalPaid">How to handle shift trades which involve unequal paid times.</param>
    /// <param name="OneSided">How to handle one-sided shift trades.</param>
    /// <param name="WeeklyMinPaidViolations">How to handle shift trades which result in violations of weekly minimum paid time constraint.</param>
    /// <param name="WeeklyMaxPaidViolations">How to handle shift trades which result in violations of weekly maximum paid time constraint.</param>
    /// <param name="RequiresMatchingQueues">Whether to constrain shift trades to agents with matching queues.</param>
    /// <param name="RequiresMatchingLanguages">Whether to constrain shift trades to agents with matching languages.</param>
    /// <param name="RequiresMatchingSkills">Whether to constrain shift trades to agents with matching skills.</param>
    /// <param name="RequiresMatchingPlanningGroups">Whether to constrain shift trades to agents with matching planning groups.</param>
    /// <param name="ActivityCategoryRules">Rules that specify what to do with activity categories that are part of a shift defined in a trade.</param>
    public ShiftTradeSettings(bool? Enabled = null, bool? AutoReview = null, bool? AllowDirectTrades = null, int? MinHoursInFuture = null, UnequalPaidEnum? UnequalPaid = null, OneSidedEnum? OneSided = null, WeeklyMinPaidViolationsEnum? WeeklyMinPaidViolations = null, WeeklyMaxPaidViolationsEnum? WeeklyMaxPaidViolations = null, bool? RequiresMatchingQueues = null, bool? RequiresMatchingLanguages = null, bool? RequiresMatchingSkills = null, bool? RequiresMatchingPlanningGroups = null, List<ShiftTradeActivityRule> ActivityCategoryRules = null)
    {
        this.Enabled = Enabled;
        this.AutoReview = AutoReview;
        this.AllowDirectTrades = AllowDirectTrades;
        this.MinHoursInFuture = MinHoursInFuture;
        this.UnequalPaid = UnequalPaid;
        this.OneSided = OneSided;
        this.WeeklyMinPaidViolations = WeeklyMinPaidViolations;
        this.WeeklyMaxPaidViolations = WeeklyMaxPaidViolations;
        this.RequiresMatchingQueues = RequiresMatchingQueues;
        this.RequiresMatchingLanguages = RequiresMatchingLanguages;
        this.RequiresMatchingSkills = RequiresMatchingSkills;
        this.RequiresMatchingPlanningGroups = RequiresMatchingPlanningGroups;
        this.ActivityCategoryRules = ActivityCategoryRules;

    }



    /// <summary>
    /// Whether shift trading is enabled for this management unit
    /// </summary>
    /// <value>Whether shift trading is enabled for this management unit</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Whether automatic shift trade review is enabled according to the rules defined in for this management unit
    /// </summary>
    /// <value>Whether automatic shift trade review is enabled according to the rules defined in for this management unit</value>
    [DataMember(Name = "autoReview", EmitDefaultValue = false)]
    public bool? AutoReview { get; set; }



    /// <summary>
    /// Whether direct shift trades between agents are allowed
    /// </summary>
    /// <value>Whether direct shift trades between agents are allowed</value>
    [DataMember(Name = "allowDirectTrades", EmitDefaultValue = false)]
    public bool? AllowDirectTrades { get; set; }



    /// <summary>
    /// The minimum number of hours in the future shift trades are allowed
    /// </summary>
    /// <value>The minimum number of hours in the future shift trades are allowed</value>
    [DataMember(Name = "minHoursInFuture", EmitDefaultValue = false)]
    public int? MinHoursInFuture { get; set; }











    /// <summary>
    /// Whether to constrain shift trades to agents with matching queues
    /// </summary>
    /// <value>Whether to constrain shift trades to agents with matching queues</value>
    [DataMember(Name = "requiresMatchingQueues", EmitDefaultValue = false)]
    public bool? RequiresMatchingQueues { get; set; }



    /// <summary>
    /// Whether to constrain shift trades to agents with matching languages
    /// </summary>
    /// <value>Whether to constrain shift trades to agents with matching languages</value>
    [DataMember(Name = "requiresMatchingLanguages", EmitDefaultValue = false)]
    public bool? RequiresMatchingLanguages { get; set; }



    /// <summary>
    /// Whether to constrain shift trades to agents with matching skills
    /// </summary>
    /// <value>Whether to constrain shift trades to agents with matching skills</value>
    [DataMember(Name = "requiresMatchingSkills", EmitDefaultValue = false)]
    public bool? RequiresMatchingSkills { get; set; }



    /// <summary>
    /// Whether to constrain shift trades to agents with matching planning groups
    /// </summary>
    /// <value>Whether to constrain shift trades to agents with matching planning groups</value>
    [DataMember(Name = "requiresMatchingPlanningGroups", EmitDefaultValue = false)]
    public bool? RequiresMatchingPlanningGroups { get; set; }



    /// <summary>
    /// Rules that specify what to do with activity categories that are part of a shift defined in a trade
    /// </summary>
    /// <value>Rules that specify what to do with activity categories that are part of a shift defined in a trade</value>
    [DataMember(Name = "activityCategoryRules", EmitDefaultValue = false)]
    public List<ShiftTradeActivityRule> ActivityCategoryRules { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShiftTradeSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  AutoReview: ").Append(AutoReview).Append("\n");
        sb.Append("  AllowDirectTrades: ").Append(AllowDirectTrades).Append("\n");
        sb.Append("  MinHoursInFuture: ").Append(MinHoursInFuture).Append("\n");
        sb.Append("  UnequalPaid: ").Append(UnequalPaid).Append("\n");
        sb.Append("  OneSided: ").Append(OneSided).Append("\n");
        sb.Append("  WeeklyMinPaidViolations: ").Append(WeeklyMinPaidViolations).Append("\n");
        sb.Append("  WeeklyMaxPaidViolations: ").Append(WeeklyMaxPaidViolations).Append("\n");
        sb.Append("  RequiresMatchingQueues: ").Append(RequiresMatchingQueues).Append("\n");
        sb.Append("  RequiresMatchingLanguages: ").Append(RequiresMatchingLanguages).Append("\n");
        sb.Append("  RequiresMatchingSkills: ").Append(RequiresMatchingSkills).Append("\n");
        sb.Append("  RequiresMatchingPlanningGroups: ").Append(RequiresMatchingPlanningGroups).Append("\n");
        sb.Append("  ActivityCategoryRules: ").Append(ActivityCategoryRules).Append("\n");
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
        return this.Equals(obj as ShiftTradeSettings);
    }

    /// <summary>
    /// Returns true if ShiftTradeSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ShiftTradeSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShiftTradeSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Enabled == other.Enabled ||
                this.Enabled != null &&
                this.Enabled.Equals(other.Enabled)
            ) &&
            (
                this.AutoReview == other.AutoReview ||
                this.AutoReview != null &&
                this.AutoReview.Equals(other.AutoReview)
            ) &&
            (
                this.AllowDirectTrades == other.AllowDirectTrades ||
                this.AllowDirectTrades != null &&
                this.AllowDirectTrades.Equals(other.AllowDirectTrades)
            ) &&
            (
                this.MinHoursInFuture == other.MinHoursInFuture ||
                this.MinHoursInFuture != null &&
                this.MinHoursInFuture.Equals(other.MinHoursInFuture)
            ) &&
            (
                this.UnequalPaid == other.UnequalPaid ||
                this.UnequalPaid != null &&
                this.UnequalPaid.Equals(other.UnequalPaid)
            ) &&
            (
                this.OneSided == other.OneSided ||
                this.OneSided != null &&
                this.OneSided.Equals(other.OneSided)
            ) &&
            (
                this.WeeklyMinPaidViolations == other.WeeklyMinPaidViolations ||
                this.WeeklyMinPaidViolations != null &&
                this.WeeklyMinPaidViolations.Equals(other.WeeklyMinPaidViolations)
            ) &&
            (
                this.WeeklyMaxPaidViolations == other.WeeklyMaxPaidViolations ||
                this.WeeklyMaxPaidViolations != null &&
                this.WeeklyMaxPaidViolations.Equals(other.WeeklyMaxPaidViolations)
            ) &&
            (
                this.RequiresMatchingQueues == other.RequiresMatchingQueues ||
                this.RequiresMatchingQueues != null &&
                this.RequiresMatchingQueues.Equals(other.RequiresMatchingQueues)
            ) &&
            (
                this.RequiresMatchingLanguages == other.RequiresMatchingLanguages ||
                this.RequiresMatchingLanguages != null &&
                this.RequiresMatchingLanguages.Equals(other.RequiresMatchingLanguages)
            ) &&
            (
                this.RequiresMatchingSkills == other.RequiresMatchingSkills ||
                this.RequiresMatchingSkills != null &&
                this.RequiresMatchingSkills.Equals(other.RequiresMatchingSkills)
            ) &&
            (
                this.RequiresMatchingPlanningGroups == other.RequiresMatchingPlanningGroups ||
                this.RequiresMatchingPlanningGroups != null &&
                this.RequiresMatchingPlanningGroups.Equals(other.RequiresMatchingPlanningGroups)
            ) &&
            (
                this.ActivityCategoryRules == other.ActivityCategoryRules ||
                this.ActivityCategoryRules != null &&
                this.ActivityCategoryRules.SequenceEqual(other.ActivityCategoryRules)
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
            if (this.Enabled != null)
            {
                hash = hash * 59 + this.Enabled.GetHashCode();
            }

            if (this.AutoReview != null)
            {
                hash = hash * 59 + this.AutoReview.GetHashCode();
            }

            if (this.AllowDirectTrades != null)
            {
                hash = hash * 59 + this.AllowDirectTrades.GetHashCode();
            }

            if (this.MinHoursInFuture != null)
            {
                hash = hash * 59 + this.MinHoursInFuture.GetHashCode();
            }

            if (this.UnequalPaid != null)
            {
                hash = hash * 59 + this.UnequalPaid.GetHashCode();
            }

            if (this.OneSided != null)
            {
                hash = hash * 59 + this.OneSided.GetHashCode();
            }

            if (this.WeeklyMinPaidViolations != null)
            {
                hash = hash * 59 + this.WeeklyMinPaidViolations.GetHashCode();
            }

            if (this.WeeklyMaxPaidViolations != null)
            {
                hash = hash * 59 + this.WeeklyMaxPaidViolations.GetHashCode();
            }

            if (this.RequiresMatchingQueues != null)
            {
                hash = hash * 59 + this.RequiresMatchingQueues.GetHashCode();
            }

            if (this.RequiresMatchingLanguages != null)
            {
                hash = hash * 59 + this.RequiresMatchingLanguages.GetHashCode();
            }

            if (this.RequiresMatchingSkills != null)
            {
                hash = hash * 59 + this.RequiresMatchingSkills.GetHashCode();
            }

            if (this.RequiresMatchingPlanningGroups != null)
            {
                hash = hash * 59 + this.RequiresMatchingPlanningGroups.GetHashCode();
            }

            if (this.ActivityCategoryRules != null)
            {
                hash = hash * 59 + this.ActivityCategoryRules.GetHashCode();
            }

            return hash;
        }
    }
}
