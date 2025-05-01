using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCallEventTopicErrorBody
/// </summary>
[DataContract]
public partial class QueueConversationCallEventTopicErrorBody : IEquatable<QueueConversationCallEventTopicErrorBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCallEventTopicErrorBody" /> class.
    /// </summary>
    /// <param name="Message">Message.</param>
    /// <param name="Code">Code.</param>
    /// <param name="Status">Status.</param>
    /// <param name="EntityId">EntityId.</param>
    /// <param name="EntityName">EntityName.</param>
    /// <param name="MessageWithParams">MessageWithParams.</param>
    /// <param name="MessageParams">MessageParams.</param>
    /// <param name="ContextId">ContextId.</param>
    /// <param name="Details">Details.</param>
    /// <param name="Errors">Errors.</param>
    /// <param name="Limit">Limit.</param>
    public QueueConversationCallEventTopicErrorBody(string Message = null, string Code = null, long? Status = null, string EntityId = null, string EntityName = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null, string ContextId = null, List<QueueConversationCallEventTopicDetail> Details = null, List<QueueConversationCallEventTopicErrorBody> Errors = null, QueueConversationCallEventTopicLimit Limit = null)
    {
        this.Message = Message;
        this.Code = Code;
        this.Status = Status;
        this.EntityId = EntityId;
        this.EntityName = EntityName;
        this.MessageWithParams = MessageWithParams;
        this.MessageParams = MessageParams;
        this.ContextId = ContextId;
        this.Details = Details;
        this.Errors = Errors;
        this.Limit = Limit;

    }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }



    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public long? Status { get; set; }



    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    [DataMember(Name = "entityId", EmitDefaultValue = false)]
    public string EntityId { get; set; }



    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    [DataMember(Name = "entityName", EmitDefaultValue = false)]
    public string EntityName { get; set; }



    /// <summary>
    /// Gets or Sets MessageWithParams
    /// </summary>
    [DataMember(Name = "messageWithParams", EmitDefaultValue = false)]
    public string MessageWithParams { get; set; }



    /// <summary>
    /// Gets or Sets MessageParams
    /// </summary>
    [DataMember(Name = "messageParams", EmitDefaultValue = false)]
    public Dictionary<string, string> MessageParams { get; set; }



    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    [DataMember(Name = "contextId", EmitDefaultValue = false)]
    public string ContextId { get; set; }



    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [DataMember(Name = "details", EmitDefaultValue = false)]
    public List<QueueConversationCallEventTopicDetail> Details { get; set; }



    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [DataMember(Name = "errors", EmitDefaultValue = false)]
    public List<QueueConversationCallEventTopicErrorBody> Errors { get; set; }



    /// <summary>
    /// Gets or Sets Limit
    /// </summary>
    [DataMember(Name = "limit", EmitDefaultValue = false)]
    public QueueConversationCallEventTopicLimit Limit { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationCallEventTopicErrorBody {\n");

        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  EntityId: ").Append(EntityId).Append("\n");
        sb.Append("  EntityName: ").Append(EntityName).Append("\n");
        sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
        sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  Details: ").Append(Details).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  Limit: ").Append(Limit).Append("\n");
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
        return Equals(obj as QueueConversationCallEventTopicErrorBody);
    }

    /// <summary>
    /// Returns true if QueueConversationCallEventTopicErrorBody instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCallEventTopicErrorBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCallEventTopicErrorBody other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
                MessageWithParams == other.MessageWithParams ||
                MessageWithParams != null &&
                MessageWithParams.Equals(other.MessageWithParams)
            ) &&
            (
                MessageParams == other.MessageParams ||
                MessageParams != null &&
                MessageParams.SequenceEqual(other.MessageParams)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                Details == other.Details ||
                Details != null &&
                Details.SequenceEqual(other.Details)
            ) &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
            ) &&
            (
                Limit == other.Limit ||
                Limit != null &&
                Limit.Equals(other.Limit)
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
            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (EntityId != null)
            {
                hash = hash * 59 + EntityId.GetHashCode();
            }

            if (EntityName != null)
            {
                hash = hash * 59 + EntityName.GetHashCode();
            }

            if (MessageWithParams != null)
            {
                hash = hash * 59 + MessageWithParams.GetHashCode();
            }

            if (MessageParams != null)
            {
                hash = hash * 59 + MessageParams.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (Details != null)
            {
                hash = hash * 59 + Details.GetHashCode();
            }

            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            if (Limit != null)
            {
                hash = hash * 59 + Limit.GetHashCode();
            }

            return hash;
        }
    }
}
