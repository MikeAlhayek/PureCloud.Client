using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation
/// </summary>
[DataContract]
public partial class WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation : IEquatable<WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,

        /// <summary>
        /// Enum Denied for "Denied"
        /// </summary>
        [EnumMember(Value = "Denied")]
        Denied
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="LengthMinutes">LengthMinutes.</param>
    /// <param name="Status">Status.</param>
    public WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation(string Id = null, DateTime? StartDate = null, long? LengthMinutes = null, StatusEnum? Status = null)
    {
        this.Id = Id;
        this.StartDate = StartDate;
        this.LengthMinutes = LengthMinutes;
        this.Status = Status;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Gets or Sets LengthMinutes
    /// </summary>
    [DataMember(Name = "lengthMinutes", EmitDefaultValue = false)]
    public long? LengthMinutes { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return this.Equals(obj as WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation);
    }

    /// <summary>
    /// Returns true if WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserScheduleAdherenceUpdatedMuTopicRealTimeAdherenceExplanation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.StartDate == other.StartDate ||
                this.StartDate != null &&
                this.StartDate.Equals(other.StartDate)
            ) &&
            (
                this.LengthMinutes == other.LengthMinutes ||
                this.LengthMinutes != null &&
                this.LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                this.Status == other.Status ||
                this.Status != null &&
                this.Status.Equals(other.Status)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.StartDate != null)
            {
                hash = hash * 59 + this.StartDate.GetHashCode();
            }

            if (this.LengthMinutes != null)
            {
                hash = hash * 59 + this.LengthMinutes.GetHashCode();
            }

            if (this.Status != null)
            {
                hash = hash * 59 + this.Status.GetHashCode();
            }

            return hash;
        }
    }
}
