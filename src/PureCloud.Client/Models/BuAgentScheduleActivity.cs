using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuAgentScheduleActivity
/// </summary>

public partial class BuAgentScheduleActivity : IEquatable<BuAgentScheduleActivity>
{
    /// <summary>
    /// The type of the external activity associated with this activity, if applicable
    /// </summary>
    /// <value>The type of the external activity associated with this activity, if applicable</value>
    
    public enum ExternalActivityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Activityplan for "ActivityPlan"
        /// </summary>
        [EnumMember(Value = "ActivityPlan")]
        Activityplan,

        /// <summary>
        /// Enum Coaching for "Coaching"
        /// </summary>
        [EnumMember(Value = "Coaching")]
        Coaching,

        /// <summary>
        /// Enum Learning for "Learning"
        /// </summary>
        [EnumMember(Value = "Learning")]
        Learning
    }
    /// <summary>
    /// The type of the external activity associated with this activity, if applicable
    /// </summary>
    /// <value>The type of the external activity associated with this activity, if applicable</value>
    [JsonPropertyName("externalActivityType")]
    public ExternalActivityTypeEnum? ExternalActivityType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuAgentScheduleActivity" /> class.
    /// </summary>
    /// <param name="StartDate">The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="LengthMinutes">The length of this activity in minutes.</param>
    /// <param name="Description">The description of this activity.</param>
    /// <param name="ActivityCodeId">The ID of the activity code associated with this activity.</param>
    /// <param name="Paid">Whether this activity is paid.</param>
    /// <param name="PayableMinutes">Payable minutes for this activity.</param>
    /// <param name="TimeOffRequestId">The ID of the time off request associated with this activity, if applicable.</param>
    /// <param name="TimeOffRequestSyncVersion">The sync version of the partial day time off request for which the scheduled activity is associated, if applicable.</param>
    /// <param name="ExternalActivityId">The ID of the external activity associated with this activity, if applicable.</param>
    /// <param name="ExternalActivityType">The type of the external activity associated with this activity, if applicable.</param>
    public BuAgentScheduleActivity(DateTime? StartDate = null, int? LengthMinutes = null, string Description = null, string ActivityCodeId = null, bool? Paid = null, int? PayableMinutes = null, string TimeOffRequestId = null, int? TimeOffRequestSyncVersion = null, string ExternalActivityId = null, ExternalActivityTypeEnum? ExternalActivityType = null)
    {
        this.StartDate = StartDate;
        this.LengthMinutes = LengthMinutes;
        this.Description = Description;
        this.ActivityCodeId = ActivityCodeId;
        this.Paid = Paid;
        this.PayableMinutes = PayableMinutes;
        this.TimeOffRequestId = TimeOffRequestId;
        this.TimeOffRequestSyncVersion = TimeOffRequestSyncVersion;
        this.ExternalActivityId = ExternalActivityId;
        this.ExternalActivityType = ExternalActivityType;

    }



    /// <summary>
    /// The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date/time of this activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The length of this activity in minutes
    /// </summary>
    /// <value>The length of this activity in minutes</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; set; }



    /// <summary>
    /// The description of this activity
    /// </summary>
    /// <value>The description of this activity</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The ID of the activity code associated with this activity
    /// </summary>
    /// <value>The ID of the activity code associated with this activity</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Whether this activity is paid
    /// </summary>
    /// <value>Whether this activity is paid</value>
    [JsonPropertyName("paid")]
    public bool? Paid { get; set; }



    /// <summary>
    /// Payable minutes for this activity
    /// </summary>
    /// <value>Payable minutes for this activity</value>
    [JsonPropertyName("payableMinutes")]
    public int? PayableMinutes { get; set; }



    /// <summary>
    /// The ID of the time off request associated with this activity, if applicable
    /// </summary>
    /// <value>The ID of the time off request associated with this activity, if applicable</value>
    [JsonPropertyName("timeOffRequestId")]
    public string TimeOffRequestId { get; set; }



    /// <summary>
    /// The sync version of the partial day time off request for which the scheduled activity is associated, if applicable
    /// </summary>
    /// <value>The sync version of the partial day time off request for which the scheduled activity is associated, if applicable</value>
    [JsonPropertyName("timeOffRequestSyncVersion")]
    public int? TimeOffRequestSyncVersion { get; set; }



    /// <summary>
    /// The ID of the external activity associated with this activity, if applicable
    /// </summary>
    /// <value>The ID of the external activity associated with this activity, if applicable</value>
    [JsonPropertyName("externalActivityId")]
    public string ExternalActivityId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuAgentScheduleActivity {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  Paid: ").Append(Paid).Append("\n");
        sb.Append("  PayableMinutes: ").Append(PayableMinutes).Append("\n");
        sb.Append("  TimeOffRequestId: ").Append(TimeOffRequestId).Append("\n");
        sb.Append("  TimeOffRequestSyncVersion: ").Append(TimeOffRequestSyncVersion).Append("\n");
        sb.Append("  ExternalActivityId: ").Append(ExternalActivityId).Append("\n");
        sb.Append("  ExternalActivityType: ").Append(ExternalActivityType).Append("\n");
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
        return Equals(obj as BuAgentScheduleActivity);
    }

    /// <summary>
    /// Returns true if BuAgentScheduleActivity instances are equal
    /// </summary>
    /// <param name="other">Instance of BuAgentScheduleActivity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuAgentScheduleActivity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                Paid == other.Paid ||
                Paid != null &&
                Paid.Equals(other.Paid)
            ) &&
            (
                PayableMinutes == other.PayableMinutes ||
                PayableMinutes != null &&
                PayableMinutes.Equals(other.PayableMinutes)
            ) &&
            (
                TimeOffRequestId == other.TimeOffRequestId ||
                TimeOffRequestId != null &&
                TimeOffRequestId.Equals(other.TimeOffRequestId)
            ) &&
            (
                TimeOffRequestSyncVersion == other.TimeOffRequestSyncVersion ||
                TimeOffRequestSyncVersion != null &&
                TimeOffRequestSyncVersion.Equals(other.TimeOffRequestSyncVersion)
            ) &&
            (
                ExternalActivityId == other.ExternalActivityId ||
                ExternalActivityId != null &&
                ExternalActivityId.Equals(other.ExternalActivityId)
            ) &&
            (
                ExternalActivityType == other.ExternalActivityType ||
                ExternalActivityType != null &&
                ExternalActivityType.Equals(other.ExternalActivityType)
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
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (Paid != null)
            {
                hash = hash * 59 + Paid.GetHashCode();
            }

            if (PayableMinutes != null)
            {
                hash = hash * 59 + PayableMinutes.GetHashCode();
            }

            if (TimeOffRequestId != null)
            {
                hash = hash * 59 + TimeOffRequestId.GetHashCode();
            }

            if (TimeOffRequestSyncVersion != null)
            {
                hash = hash * 59 + TimeOffRequestSyncVersion.GetHashCode();
            }

            if (ExternalActivityId != null)
            {
                hash = hash * 59 + ExternalActivityId.GetHashCode();
            }

            if (ExternalActivityType != null)
            {
                hash = hash * 59 + ExternalActivityType.GetHashCode();
            }

            return hash;
        }
    }
}
