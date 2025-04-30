using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// CreateTimeOffPlanRequest
    /// </summary>
    [DataContract]
    public partial class CreateTimeOffPlanRequest : IEquatable<CreateTimeOffPlanRequest>
    {
        /// <summary>
        /// Auto approval rule for the time off plan.
        /// </summary>
        /// <value>Auto approval rule for the time off plan.</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
        [DataMember(Name = "autoApprovalRule", EmitDefaultValue = false)]
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
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }



        /// <summary>
        /// The set of activity code IDs to associate with this time off plan.
        /// </summary>
        /// <value>The set of activity code IDs to associate with this time off plan.</value>
        [DataMember(Name = "activityCodeIds", EmitDefaultValue = false)]
        public List<string> ActivityCodeIds { get; set; }



        /// <summary>
        /// The set of time off limit IDs to associate with this time off plan.
        /// </summary>
        /// <value>The set of time off limit IDs to associate with this time off plan.</value>
        [DataMember(Name = "timeOffLimitIds", EmitDefaultValue = false)]
        public List<string> TimeOffLimitIds { get; set; }





        /// <summary>
        /// The number of days before the time off request start date for when the request will be expired from the waitlist.
        /// </summary>
        /// <value>The number of days before the time off request start date for when the request will be expired from the waitlist.</value>
        [DataMember(Name = "daysBeforeStartToExpireFromWaitlist", EmitDefaultValue = false)]
        public int? DaysBeforeStartToExpireFromWaitlist { get; set; }



        /// <summary>
        /// Time off type, if this time off plan is associated with the integration.
        /// </summary>
        /// <value>Time off type, if this time off plan is associated with the integration.</value>
        [DataMember(Name = "hrisTimeOffType", EmitDefaultValue = false)]
        public HrisTimeOffType HrisTimeOffType { get; set; }



        /// <summary>
        /// Whether this time off plan should be used by agents.
        /// </summary>
        /// <value>Whether this time off plan should be used by agents.</value>
        [DataMember(Name = "active", EmitDefaultValue = false)]
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
            return this.Equals(obj as CreateTimeOffPlanRequest);
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
                return false;

            return true &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ActivityCodeIds == other.ActivityCodeIds ||
                    this.ActivityCodeIds != null &&
                    this.ActivityCodeIds.SequenceEqual(other.ActivityCodeIds)
                ) &&
                (
                    this.TimeOffLimitIds == other.TimeOffLimitIds ||
                    this.TimeOffLimitIds != null &&
                    this.TimeOffLimitIds.SequenceEqual(other.TimeOffLimitIds)
                ) &&
                (
                    this.AutoApprovalRule == other.AutoApprovalRule ||
                    this.AutoApprovalRule != null &&
                    this.AutoApprovalRule.Equals(other.AutoApprovalRule)
                ) &&
                (
                    this.DaysBeforeStartToExpireFromWaitlist == other.DaysBeforeStartToExpireFromWaitlist ||
                    this.DaysBeforeStartToExpireFromWaitlist != null &&
                    this.DaysBeforeStartToExpireFromWaitlist.Equals(other.DaysBeforeStartToExpireFromWaitlist)
                ) &&
                (
                    this.HrisTimeOffType == other.HrisTimeOffType ||
                    this.HrisTimeOffType != null &&
                    this.HrisTimeOffType.Equals(other.HrisTimeOffType)
                ) &&
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.ActivityCodeIds != null)
                    hash = hash * 59 + this.ActivityCodeIds.GetHashCode();

                if (this.TimeOffLimitIds != null)
                    hash = hash * 59 + this.TimeOffLimitIds.GetHashCode();

                if (this.AutoApprovalRule != null)
                    hash = hash * 59 + this.AutoApprovalRule.GetHashCode();

                if (this.DaysBeforeStartToExpireFromWaitlist != null)
                    hash = hash * 59 + this.DaysBeforeStartToExpireFromWaitlist.GetHashCode();

                if (this.HrisTimeOffType != null)
                    hash = hash * 59 + this.HrisTimeOffType.GetHashCode();

                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();

                return hash;
            }
        }
    }

}
