using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationCobrowseEventTopicDetail
/// </summary>

public partial class ConversationCobrowseEventTopicDetail : IEquatable<ConversationCobrowseEventTopicDetail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationCobrowseEventTopicDetail" /> class.
    /// </summary>
    /// <param name="ErrorCode">ErrorCode.</param>
    /// <param name="FieldName">FieldName.</param>
    /// <param name="EntityId">EntityId.</param>
    /// <param name="EntityName">EntityName.</param>
    public ConversationCobrowseEventTopicDetail(string ErrorCode = null, string FieldName = null, string EntityId = null, string EntityName = null)
    {
        this.ErrorCode = ErrorCode;
        this.FieldName = FieldName;
        this.EntityId = EntityId;
        this.EntityName = EntityName;

    }



    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [JsonPropertyName("errorCode")]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    [JsonPropertyName("fieldName")]
    public string FieldName { get; set; }



    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    [JsonPropertyName("entityId")]
    public string EntityId { get; set; }



    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    [JsonPropertyName("entityName")]
    public string EntityName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationCobrowseEventTopicDetail {\n");

        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  FieldName: ").Append(FieldName).Append("\n");
        sb.Append("  EntityId: ").Append(EntityId).Append("\n");
        sb.Append("  EntityName: ").Append(EntityName).Append("\n");
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
        return Equals(obj as ConversationCobrowseEventTopicDetail);
    }

    /// <summary>
    /// Returns true if ConversationCobrowseEventTopicDetail instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationCobrowseEventTopicDetail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationCobrowseEventTopicDetail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                FieldName == other.FieldName ||
                FieldName != null &&
                FieldName.Equals(other.FieldName)
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
            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (FieldName != null)
            {
                hash = hash * 59 + FieldName.GetHashCode();
            }

            if (EntityId != null)
            {
                hash = hash * 59 + EntityId.GetHashCode();
            }

            if (EntityName != null)
            {
                hash = hash * 59 + EntityName.GetHashCode();
            }

            return hash;
        }
    }
}
