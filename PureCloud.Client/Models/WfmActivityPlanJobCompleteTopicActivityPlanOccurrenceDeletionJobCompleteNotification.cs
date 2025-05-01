using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification
/// </summary>
[DataContract]
public partial class WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification : IEquatable<WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification>
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
        /// Enum Runplan for "RunPlan"
        /// </summary>
        [EnumMember(Value = "RunPlan")]
        Runplan,

        /// <summary>
        /// Enum Deleteoccurrence for "DeleteOccurrence"
        /// </summary>
        [EnumMember(Value = "DeleteOccurrence")]
        Deleteoccurrence
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
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
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
    /// Initializes a new instance of the <see cref="WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Type">Type.</param>
    /// <param name="ActivityPlan">ActivityPlan.</param>
    /// <param name="Status">Status.</param>
    /// <param name="Exceptions">Exceptions.</param>
    /// <param name="Error">Error.</param>
    /// <param name="Occurrence">Occurrence.</param>
    public WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification(string Id = null, TypeEnum? Type = null, WfmActivityPlanJobCompleteTopicActivityPlanReference ActivityPlan = null, StatusEnum? Status = null, List<WfmActivityPlanJobCompleteTopicActivityPlanJobException> Exceptions = null, WfmActivityPlanJobCompleteTopicErrorBody Error = null, WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference Occurrence = null)
    {
        this.Id = Id;
        this.Type = Type;
        this.ActivityPlan = ActivityPlan;
        this.Status = Status;
        this.Exceptions = Exceptions;
        this.Error = Error;
        this.Occurrence = Occurrence;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }





    /// <summary>
    /// Gets or Sets ActivityPlan
    /// </summary>
    [DataMember(Name = "activityPlan", EmitDefaultValue = false)]
    public WfmActivityPlanJobCompleteTopicActivityPlanReference ActivityPlan { get; set; }





    /// <summary>
    /// Gets or Sets Exceptions
    /// </summary>
    [DataMember(Name = "exceptions", EmitDefaultValue = false)]
    public List<WfmActivityPlanJobCompleteTopicActivityPlanJobException> Exceptions { get; set; }



    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public WfmActivityPlanJobCompleteTopicErrorBody Error { get; set; }



    /// <summary>
    /// Gets or Sets Occurrence
    /// </summary>
    [DataMember(Name = "occurrence", EmitDefaultValue = false)]
    public WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceReference Occurrence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ActivityPlan: ").Append(ActivityPlan).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Exceptions: ").Append(Exceptions).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  Occurrence: ").Append(Occurrence).Append("\n");
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
        return Equals(obj as WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification);
    }

    /// <summary>
    /// Returns true if WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmActivityPlanJobCompleteTopicActivityPlanOccurrenceDeletionJobCompleteNotification other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                ActivityPlan == other.ActivityPlan ||
                ActivityPlan != null &&
                ActivityPlan.Equals(other.ActivityPlan)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Exceptions == other.Exceptions ||
                Exceptions != null &&
                Exceptions.SequenceEqual(other.Exceptions)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            ) &&
            (
                Occurrence == other.Occurrence ||
                Occurrence != null &&
                Occurrence.Equals(other.Occurrence)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (ActivityPlan != null)
            {
                hash = hash * 59 + ActivityPlan.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Exceptions != null)
            {
                hash = hash * 59 + Exceptions.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (Occurrence != null)
            {
                hash = hash * 59 + Occurrence.GetHashCode();
            }

            return hash;
        }
    }
}
