using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserNotificationTopicAdherenceExplanationNotification
/// </summary>

public partial class WfmUserNotificationTopicAdherenceExplanationNotification : IEquatable<WfmUserNotificationTopicAdherenceExplanationNotification>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
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
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserNotificationTopicAdherenceExplanationNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Agent">Agent.</param>
    /// <param name="ManagementUnit">ManagementUnit.</param>
    /// <param name="BusinessUnit">BusinessUnit.</param>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="LengthMinutes">LengthMinutes.</param>
    /// <param name="Status">Status.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Notes">Notes.</param>
    public WfmUserNotificationTopicAdherenceExplanationNotification(string Id = null, WfmUserNotificationTopicUserReference Agent = null, WfmUserNotificationTopicManagementUnit ManagementUnit = null, WfmUserNotificationTopicBusinessUnit BusinessUnit = null, DateTime? StartDate = null, long? LengthMinutes = null, StatusEnum? Status = null, TypeEnum? Type = null, string Notes = null)
    {
        this.Id = Id;
        this.Agent = Agent;
        this.ManagementUnit = ManagementUnit;
        this.BusinessUnit = BusinessUnit;
        this.StartDate = StartDate;
        this.LengthMinutes = LengthMinutes;
        this.Status = Status;
        this.Type = Type;
        this.Notes = Notes;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [JsonPropertyName("agent")]
    public WfmUserNotificationTopicUserReference Agent { get; set; }



    /// <summary>
    /// Gets or Sets ManagementUnit
    /// </summary>
    [JsonPropertyName("managementUnit")]
    public WfmUserNotificationTopicManagementUnit ManagementUnit { get; set; }



    /// <summary>
    /// Gets or Sets BusinessUnit
    /// </summary>
    [JsonPropertyName("businessUnit")]
    public WfmUserNotificationTopicBusinessUnit BusinessUnit { get; set; }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Gets or Sets LengthMinutes
    /// </summary>
    [JsonPropertyName("lengthMinutes")]
    public long? LengthMinutes { get; set; }







    /// <summary>
    /// Gets or Sets Notes
    /// </summary>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserNotificationTopicAdherenceExplanationNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
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
        return Equals(obj as WfmUserNotificationTopicAdherenceExplanationNotification);
    }

    /// <summary>
    /// Returns true if WfmUserNotificationTopicAdherenceExplanationNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserNotificationTopicAdherenceExplanationNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserNotificationTopicAdherenceExplanationNotification other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
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

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            return hash;
        }
    }
}
