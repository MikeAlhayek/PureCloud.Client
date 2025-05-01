using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2IntegrationPresenceEventPresenceActivityEvent
/// </summary>
[DataContract]
public partial class V2IntegrationPresenceEventPresenceActivityEvent : IEquatable<V2IntegrationPresenceEventPresenceActivityEvent>
{
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EventTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Userpresencestatuschanged for "UserPresenceStatusChanged"
        /// </summary>
        [EnumMember(Value = "UserPresenceStatusChanged")]
        Userpresencestatuschanged,

        /// <summary>
        /// Enum Userprimarypresencesourcechanged for "UserPrimaryPresenceSourceChanged"
        /// </summary>
        [EnumMember(Value = "UserPrimaryPresenceSourceChanged")]
        Userprimarypresencesourcechanged
    }
    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    [DataMember(Name = "eventType", EmitDefaultValue = false)]
    public EventTypeEnum? EventType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2IntegrationPresenceEventPresenceActivityEvent" /> class.
    /// </summary>
    /// <param name="UserId">UserId.</param>
    /// <param name="EventType">EventType.</param>
    /// <param name="Source">Source.</param>
    /// <param name="ModifiedDate">ModifiedDate.</param>
    /// <param name="PresenceDefinition">PresenceDefinition.</param>
    /// <param name="Message">Message.</param>
    /// <param name="CurrentDisplaySourceId">CurrentDisplaySourceId.</param>
    /// <param name="PreviousDisplaySourceId">PreviousDisplaySourceId.</param>
    public V2IntegrationPresenceEventPresenceActivityEvent(Guid? UserId = null, EventTypeEnum? EventType = null, string Source = null, DateTime? ModifiedDate = null, V2IntegrationPresenceEventOrganizationPresence PresenceDefinition = null, string Message = null, Guid? CurrentDisplaySourceId = null, Guid? PreviousDisplaySourceId = null)
    {
        this.UserId = UserId;
        this.EventType = EventType;
        this.Source = Source;
        this.ModifiedDate = ModifiedDate;
        this.PresenceDefinition = PresenceDefinition;
        this.Message = Message;
        this.CurrentDisplaySourceId = CurrentDisplaySourceId;
        this.PreviousDisplaySourceId = PreviousDisplaySourceId;

    }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public Guid? UserId { get; set; }





    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public string Source { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// Gets or Sets PresenceDefinition
    /// </summary>
    [DataMember(Name = "presenceDefinition", EmitDefaultValue = false)]
    public V2IntegrationPresenceEventOrganizationPresence PresenceDefinition { get; set; }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets CurrentDisplaySourceId
    /// </summary>
    [DataMember(Name = "currentDisplaySourceId", EmitDefaultValue = false)]
    public Guid? CurrentDisplaySourceId { get; set; }



    /// <summary>
    /// Gets or Sets PreviousDisplaySourceId
    /// </summary>
    [DataMember(Name = "previousDisplaySourceId", EmitDefaultValue = false)]
    public Guid? PreviousDisplaySourceId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2IntegrationPresenceEventPresenceActivityEvent {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  EventType: ").Append(EventType).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  PresenceDefinition: ").Append(PresenceDefinition).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  CurrentDisplaySourceId: ").Append(CurrentDisplaySourceId).Append("\n");
        sb.Append("  PreviousDisplaySourceId: ").Append(PreviousDisplaySourceId).Append("\n");
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
        return Equals(obj as V2IntegrationPresenceEventPresenceActivityEvent);
    }

    /// <summary>
    /// Returns true if V2IntegrationPresenceEventPresenceActivityEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of V2IntegrationPresenceEventPresenceActivityEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2IntegrationPresenceEventPresenceActivityEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                EventType == other.EventType ||
                EventType != null &&
                EventType.Equals(other.EventType)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                PresenceDefinition == other.PresenceDefinition ||
                PresenceDefinition != null &&
                PresenceDefinition.Equals(other.PresenceDefinition)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                CurrentDisplaySourceId == other.CurrentDisplaySourceId ||
                CurrentDisplaySourceId != null &&
                CurrentDisplaySourceId.Equals(other.CurrentDisplaySourceId)
            ) &&
            (
                PreviousDisplaySourceId == other.PreviousDisplaySourceId ||
                PreviousDisplaySourceId != null &&
                PreviousDisplaySourceId.Equals(other.PreviousDisplaySourceId)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (EventType != null)
            {
                hash = hash * 59 + EventType.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (PresenceDefinition != null)
            {
                hash = hash * 59 + PresenceDefinition.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (CurrentDisplaySourceId != null)
            {
                hash = hash * 59 + CurrentDisplaySourceId.GetHashCode();
            }

            if (PreviousDisplaySourceId != null)
            {
                hash = hash * 59 + PreviousDisplaySourceId.GetHashCode();
            }

            return hash;
        }
    }
}
