using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AvailableTime
/// </summary>
[DataContract]
public partial class AvailableTime : IEquatable<AvailableTime>
{
    /// <summary>
    /// Workforce Management activity category for this availability period
    /// </summary>
    /// <value>Workforce Management activity category for this availability period</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActivityCategoryEnum
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
        Unavailable
    }
    /// <summary>
    /// Workforce Management activity category for this availability period
    /// </summary>
    /// <value>Workforce Management activity category for this availability period</value>
    [DataMember(Name = "activityCategory", EmitDefaultValue = false)]
    public ActivityCategoryEnum? ActivityCategory { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AvailableTime" /> class.
    /// </summary>
    public AvailableTime()
    {

    }



    /// <summary>
    /// Start of the availability period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start of the availability period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public DateTime? DateStart { get; private set; }



    /// <summary>
    /// Length of availability period in minutes
    /// </summary>
    /// <value>Length of availability period in minutes</value>
    [DataMember(Name = "lengthInMinutes", EmitDefaultValue = false)]
    public int? LengthInMinutes { get; private set; }



    /// <summary>
    /// Indicates if this availability period is paid in Workforce Management schedule
    /// </summary>
    /// <value>Indicates if this availability period is paid in Workforce Management schedule</value>
    [DataMember(Name = "isPaid", EmitDefaultValue = false)]
    public bool? IsPaid { get; private set; }





    /// <summary>
    /// Workforce Management schedule information associated with the available time
    /// </summary>
    /// <value>Workforce Management schedule information associated with the available time</value>
    [DataMember(Name = "wfmSchedule", EmitDefaultValue = false)]
    public WfmScheduleReference WfmSchedule { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AvailableTime {\n");

        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  IsPaid: ").Append(IsPaid).Append("\n");
        sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
        sb.Append("  WfmSchedule: ").Append(WfmSchedule).Append("\n");
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
        return Equals(obj as AvailableTime);
    }

    /// <summary>
    /// Returns true if AvailableTime instances are equal
    /// </summary>
    /// <param name="other">Instance of AvailableTime to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AvailableTime other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                IsPaid == other.IsPaid ||
                IsPaid != null &&
                IsPaid.Equals(other.IsPaid)
            ) &&
            (
                ActivityCategory == other.ActivityCategory ||
                ActivityCategory != null &&
                ActivityCategory.Equals(other.ActivityCategory)
            ) &&
            (
                WfmSchedule == other.WfmSchedule ||
                WfmSchedule != null &&
                WfmSchedule.Equals(other.WfmSchedule)
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
            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (IsPaid != null)
            {
                hash = hash * 59 + IsPaid.GetHashCode();
            }

            if (ActivityCategory != null)
            {
                hash = hash * 59 + ActivityCategory.GetHashCode();
            }

            if (WfmSchedule != null)
            {
                hash = hash * 59 + WfmSchedule.GetHashCode();
            }

            return hash;
        }
    }
}
