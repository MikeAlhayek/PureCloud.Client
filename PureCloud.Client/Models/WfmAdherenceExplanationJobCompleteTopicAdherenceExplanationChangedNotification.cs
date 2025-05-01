using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification
/// </summary>
[DataContract]
public partial class WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification : IEquatable<WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Late for "Late"
        /// </summary>
        [EnumMember(Value = "Late")]
        Late
    }
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
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Agent">Agent.</param>
    /// <param name="ManagementUnit">ManagementUnit.</param>
    /// <param name="BusinessUnit">BusinessUnit.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Status">Status.</param>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="LengthMinutes">LengthMinutes.</param>
    /// <param name="Notes">Notes.</param>
    /// <param name="ReviewedBy">ReviewedBy.</param>
    /// <param name="ReviewedDate">ReviewedDate.</param>
    public WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification(string Id = null, WfmAdherenceExplanationJobCompleteTopicUserReference Agent = null, WfmAdherenceExplanationJobCompleteTopicManagementUnit ManagementUnit = null, WfmAdherenceExplanationJobCompleteTopicBusinessUnit BusinessUnit = null, TypeEnum? Type = null, StatusEnum? Status = null, DateTime? StartDate = null, long? LengthMinutes = null, string Notes = null, WfmAdherenceExplanationJobCompleteTopicUserReference ReviewedBy = null, DateTime? ReviewedDate = null)
    {
        this.Id = Id;
        this.Agent = Agent;
        this.ManagementUnit = ManagementUnit;
        this.BusinessUnit = BusinessUnit;
        this.Type = Type;
        this.Status = Status;
        this.StartDate = StartDate;
        this.LengthMinutes = LengthMinutes;
        this.Notes = Notes;
        this.ReviewedBy = ReviewedBy;
        this.ReviewedDate = ReviewedDate;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [DataMember(Name = "agent", EmitDefaultValue = false)]
    public WfmAdherenceExplanationJobCompleteTopicUserReference Agent { get; set; }



    /// <summary>
    /// Gets or Sets ManagementUnit
    /// </summary>
    [DataMember(Name = "managementUnit", EmitDefaultValue = false)]
    public WfmAdherenceExplanationJobCompleteTopicManagementUnit ManagementUnit { get; set; }



    /// <summary>
    /// Gets or Sets BusinessUnit
    /// </summary>
    [DataMember(Name = "businessUnit", EmitDefaultValue = false)]
    public WfmAdherenceExplanationJobCompleteTopicBusinessUnit BusinessUnit { get; set; }







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
    /// Gets or Sets Notes
    /// </summary>
    [DataMember(Name = "notes", EmitDefaultValue = false)]
    public string Notes { get; set; }



    /// <summary>
    /// Gets or Sets ReviewedBy
    /// </summary>
    [DataMember(Name = "reviewedBy", EmitDefaultValue = false)]
    public WfmAdherenceExplanationJobCompleteTopicUserReference ReviewedBy { get; set; }



    /// <summary>
    /// Gets or Sets ReviewedDate
    /// </summary>
    [DataMember(Name = "reviewedDate", EmitDefaultValue = false)]
    public DateTime? ReviewedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  ReviewedBy: ").Append(ReviewedBy).Append("\n");
        sb.Append("  ReviewedDate: ").Append(ReviewedDate).Append("\n");
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
        return Equals(obj as WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification);
    }

    /// <summary>
    /// Returns true if WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmAdherenceExplanationJobCompleteTopicAdherenceExplanationChangedNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
            ) &&
            (
                BusinessUnit == other.BusinessUnit ||
                BusinessUnit != null &&
                BusinessUnit.Equals(other.BusinessUnit)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
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
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                ReviewedBy == other.ReviewedBy ||
                ReviewedBy != null &&
                ReviewedBy.Equals(other.ReviewedBy)
            ) &&
            (
                ReviewedDate == other.ReviewedDate ||
                ReviewedDate != null &&
                ReviewedDate.Equals(other.ReviewedDate)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (BusinessUnit != null)
            {
                hash = hash * 59 + BusinessUnit.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (ReviewedBy != null)
            {
                hash = hash * 59 + ReviewedBy.GetHashCode();
            }

            if (ReviewedDate != null)
            {
                hash = hash * 59 + ReviewedDate.GetHashCode();
            }

            return hash;
        }
    }
}
