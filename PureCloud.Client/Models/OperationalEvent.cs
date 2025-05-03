using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OperationalEvent
/// </summary>

public partial class OperationalEvent : IEquatable<OperationalEvent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OperationalEvent" /> class.
    /// </summary>
    /// <param name="EventDefinition">The event that occurred..</param>
    /// <param name="EntityId">The unique identifier for the entity.</param>
    /// <param name="EntityToken">A token representing the entity.</param>
    /// <param name="EntityName">The name for the entity.</param>
    /// <param name="PreviousValue">The value prior to the event.</param>
    /// <param name="CurrentValue">The changed value following the event.</param>
    /// <param name="ErrorCode">The error code of the entity in the providing service associated to the event.</param>
    /// <param name="ParentEntityId">The unique identifier for the parent of the entity.</param>
    /// <param name="Conversation">The link to a conversation.</param>
    /// <param name="DateCreated">The date when the event created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EntityVersion">The version of the entity in the providing service.</param>
    public OperationalEvent(AddressableEntityRef EventDefinition = null, string EntityId = null, string EntityToken = null, string EntityName = null, string PreviousValue = null, string CurrentValue = null, string ErrorCode = null, string ParentEntityId = null, AddressableEntityRef Conversation = null, DateTime? DateCreated = null, string EntityVersion = null)
    {
        this.EventDefinition = EventDefinition;
        this.EntityId = EntityId;
        this.EntityToken = EntityToken;
        this.EntityName = EntityName;
        this.PreviousValue = PreviousValue;
        this.CurrentValue = CurrentValue;
        this.ErrorCode = ErrorCode;
        this.ParentEntityId = ParentEntityId;
        this.Conversation = Conversation;
        this.DateCreated = DateCreated;
        this.EntityVersion = EntityVersion;

    }



    /// <summary>
    /// The event that occurred.
    /// </summary>
    /// <value>The event that occurred.</value>
    [JsonPropertyName("eventDefinition")]
    public AddressableEntityRef EventDefinition { get; set; }



    /// <summary>
    /// The unique identifier for the entity
    /// </summary>
    /// <value>The unique identifier for the entity</value>
    [JsonPropertyName("entityId")]
    public string EntityId { get; set; }



    /// <summary>
    /// A token representing the entity
    /// </summary>
    /// <value>A token representing the entity</value>
    [JsonPropertyName("entityToken")]
    public string EntityToken { get; set; }



    /// <summary>
    /// The name for the entity
    /// </summary>
    /// <value>The name for the entity</value>
    [JsonPropertyName("entityName")]
    public string EntityName { get; set; }



    /// <summary>
    /// The value prior to the event
    /// </summary>
    /// <value>The value prior to the event</value>
    [JsonPropertyName("previousValue")]
    public string PreviousValue { get; set; }



    /// <summary>
    /// The changed value following the event
    /// </summary>
    /// <value>The changed value following the event</value>
    [JsonPropertyName("currentValue")]
    public string CurrentValue { get; set; }



    /// <summary>
    /// The error code of the entity in the providing service associated to the event
    /// </summary>
    /// <value>The error code of the entity in the providing service associated to the event</value>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// The unique identifier for the parent of the entity
    /// </summary>
    /// <value>The unique identifier for the parent of the entity</value>
    [JsonPropertyName("parentEntityId")]
    public string ParentEntityId { get; set; }



    /// <summary>
    /// The link to a conversation
    /// </summary>
    /// <value>The link to a conversation</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; set; }



    /// <summary>
    /// The date when the event created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the event created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The version of the entity in the providing service
    /// </summary>
    /// <value>The version of the entity in the providing service</value>
    [JsonPropertyName("entityVersion")]
    public string EntityVersion { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OperationalEvent {\n");

        sb.Append("  EventDefinition: ").Append(EventDefinition).Append("\n");
        sb.Append("  EntityId: ").Append(EntityId).Append("\n");
        sb.Append("  EntityToken: ").Append(EntityToken).Append("\n");
        sb.Append("  EntityName: ").Append(EntityName).Append("\n");
        sb.Append("  PreviousValue: ").Append(PreviousValue).Append("\n");
        sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ParentEntityId: ").Append(ParentEntityId).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  EntityVersion: ").Append(EntityVersion).Append("\n");
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
        return Equals(obj as OperationalEvent);
    }

    /// <summary>
    /// Returns true if OperationalEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of OperationalEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OperationalEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventDefinition == other.EventDefinition ||
                EventDefinition != null &&
                EventDefinition.Equals(other.EventDefinition)
            ) &&
            (
                EntityId == other.EntityId ||
                EntityId != null &&
                EntityId.Equals(other.EntityId)
            ) &&
            (
                EntityToken == other.EntityToken ||
                EntityToken != null &&
                EntityToken.Equals(other.EntityToken)
            ) &&
            (
                EntityName == other.EntityName ||
                EntityName != null &&
                EntityName.Equals(other.EntityName)
            ) &&
            (
                PreviousValue == other.PreviousValue ||
                PreviousValue != null &&
                PreviousValue.Equals(other.PreviousValue)
            ) &&
            (
                CurrentValue == other.CurrentValue ||
                CurrentValue != null &&
                CurrentValue.Equals(other.CurrentValue)
            ) &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                ParentEntityId == other.ParentEntityId ||
                ParentEntityId != null &&
                ParentEntityId.Equals(other.ParentEntityId)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                EntityVersion == other.EntityVersion ||
                EntityVersion != null &&
                EntityVersion.Equals(other.EntityVersion)
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
            if (EventDefinition != null)
            {
                hash = hash * 59 + EventDefinition.GetHashCode();
            }

            if (EntityId != null)
            {
                hash = hash * 59 + EntityId.GetHashCode();
            }

            if (EntityToken != null)
            {
                hash = hash * 59 + EntityToken.GetHashCode();
            }

            if (EntityName != null)
            {
                hash = hash * 59 + EntityName.GetHashCode();
            }

            if (PreviousValue != null)
            {
                hash = hash * 59 + PreviousValue.GetHashCode();
            }

            if (CurrentValue != null)
            {
                hash = hash * 59 + CurrentValue.GetHashCode();
            }

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (ParentEntityId != null)
            {
                hash = hash * 59 + ParentEntityId.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (EntityVersion != null)
            {
                hash = hash * 59 + EntityVersion.GetHashCode();
            }

            return hash;
        }
    }
}
