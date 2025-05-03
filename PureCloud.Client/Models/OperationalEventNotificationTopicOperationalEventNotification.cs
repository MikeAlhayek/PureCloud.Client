using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OperationalEventNotificationTopicOperationalEventNotification
/// </summary>

public partial class OperationalEventNotificationTopicOperationalEventNotification : IEquatable<OperationalEventNotificationTopicOperationalEventNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OperationalEventNotificationTopicOperationalEventNotification" /> class.
    /// </summary>
    /// <param name="EventEntity">EventEntity.</param>
    /// <param name="EntityId">EntityId.</param>
    /// <param name="EntityName">EntityName.</param>
    /// <param name="PreviousValue">PreviousValue.</param>
    /// <param name="CurrentValue">CurrentValue.</param>
    /// <param name="ErrorCode">ErrorCode.</param>
    /// <param name="Version">Version.</param>
    /// <param name="ParentEntity">ParentEntity.</param>
    /// <param name="EntityType">EntityType.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="EntityToken">EntityToken.</param>
    /// <param name="Timestamp">Timestamp.</param>
    public OperationalEventNotificationTopicOperationalEventNotification(OperationalEventNotificationTopicEventEntity EventEntity = null, Guid? EntityId = null, string EntityName = null, string PreviousValue = null, string CurrentValue = null, string ErrorCode = null, string Version = null, Guid? ParentEntity = null, string EntityType = null, Guid? ConversationId = null, string EntityToken = null, long? Timestamp = null)
    {
        this.EventEntity = EventEntity;
        this.EntityId = EntityId;
        this.EntityName = EntityName;
        this.PreviousValue = PreviousValue;
        this.CurrentValue = CurrentValue;
        this.ErrorCode = ErrorCode;
        this.Version = Version;
        this.ParentEntity = ParentEntity;
        this.EntityType = EntityType;
        this.ConversationId = ConversationId;
        this.EntityToken = EntityToken;
        this.Timestamp = Timestamp;

    }



    /// <summary>
    /// Gets or Sets EventEntity
    /// </summary>
    [JsonPropertyName("eventEntity")]
    public OperationalEventNotificationTopicEventEntity EventEntity { get; set; }



    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    [JsonPropertyName("entityId")]
    public Guid? EntityId { get; set; }



    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    [JsonPropertyName("entityName")]
    public string EntityName { get; set; }



    /// <summary>
    /// Gets or Sets PreviousValue
    /// </summary>
    [JsonPropertyName("previousValue")]
    public string PreviousValue { get; set; }



    /// <summary>
    /// Gets or Sets CurrentValue
    /// </summary>
    [JsonPropertyName("currentValue")]
    public string CurrentValue { get; set; }



    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; set; }



    /// <summary>
    /// Gets or Sets ParentEntity
    /// </summary>
    [JsonPropertyName("parentEntity")]
    public Guid? ParentEntity { get; set; }



    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    [JsonPropertyName("entityType")]
    public string EntityType { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public Guid? ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets EntityToken
    /// </summary>
    [JsonPropertyName("entityToken")]
    public string EntityToken { get; set; }



    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [JsonPropertyName("timestamp")]
    public long? Timestamp { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OperationalEventNotificationTopicOperationalEventNotification {\n");

        sb.Append("  EventEntity: ").Append(EventEntity).Append("\n");
        sb.Append("  EntityId: ").Append(EntityId).Append("\n");
        sb.Append("  EntityName: ").Append(EntityName).Append("\n");
        sb.Append("  PreviousValue: ").Append(PreviousValue).Append("\n");
        sb.Append("  CurrentValue: ").Append(CurrentValue).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ParentEntity: ").Append(ParentEntity).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  EntityToken: ").Append(EntityToken).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
        return Equals(obj as OperationalEventNotificationTopicOperationalEventNotification);
    }

    /// <summary>
    /// Returns true if OperationalEventNotificationTopicOperationalEventNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of OperationalEventNotificationTopicOperationalEventNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OperationalEventNotificationTopicOperationalEventNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventEntity == other.EventEntity ||
                EventEntity != null &&
                EventEntity.Equals(other.EventEntity)
            ) &&
            (
                EntityId == other.EntityId ||
                EntityId != null &&
                EntityId.Equals(other.EntityId)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                ParentEntity == other.ParentEntity ||
                ParentEntity != null &&
                ParentEntity.Equals(other.ParentEntity)
            ) &&
            (
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                EntityToken == other.EntityToken ||
                EntityToken != null &&
                EntityToken.Equals(other.EntityToken)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
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
            if (EventEntity != null)
            {
                hash = hash * 59 + EventEntity.GetHashCode();
            }

            if (EntityId != null)
            {
                hash = hash * 59 + EntityId.GetHashCode();
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (ParentEntity != null)
            {
                hash = hash * 59 + ParentEntity.GetHashCode();
            }

            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (EntityToken != null)
            {
                hash = hash * 59 + EntityToken.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            return hash;
        }
    }
}
