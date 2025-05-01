using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationMessageEventTopicDetail
/// </summary>
[DataContract]
public partial class ConversationMessageEventTopicDetail : IEquatable<ConversationMessageEventTopicDetail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationMessageEventTopicDetail" /> class.
    /// </summary>
    /// <param name="ErrorCode">ErrorCode.</param>
    /// <param name="FieldName">FieldName.</param>
    /// <param name="EntityId">EntityId.</param>
    /// <param name="EntityName">EntityName.</param>
    public ConversationMessageEventTopicDetail(string ErrorCode = null, string FieldName = null, string EntityId = null, string EntityName = null)
    {
        this.ErrorCode = ErrorCode;
        this.FieldName = FieldName;
        this.EntityId = EntityId;
        this.EntityName = EntityName;

    }



    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }



    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    [DataMember(Name = "fieldName", EmitDefaultValue = false)]
    public string FieldName { get; set; }



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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationMessageEventTopicDetail {\n");

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
        return this.Equals(obj as ConversationMessageEventTopicDetail);
    }

    /// <summary>
    /// Returns true if ConversationMessageEventTopicDetail instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationMessageEventTopicDetail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationMessageEventTopicDetail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.ErrorCode == other.ErrorCode ||
                this.ErrorCode != null &&
                this.ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                this.FieldName == other.FieldName ||
                this.FieldName != null &&
                this.FieldName.Equals(other.FieldName)
            ) &&
            (
                this.EntityId == other.EntityId ||
                this.EntityId != null &&
                this.EntityId.Equals(other.EntityId)
            ) &&
            (
                this.EntityName == other.EntityName ||
                this.EntityName != null &&
                this.EntityName.Equals(other.EntityName)
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
            if (this.ErrorCode != null)
            {
                hash = hash * 59 + this.ErrorCode.GetHashCode();
            }

            if (this.FieldName != null)
            {
                hash = hash * 59 + this.FieldName.GetHashCode();
            }

            if (this.EntityId != null)
            {
                hash = hash * 59 + this.EntityId.GetHashCode();
            }

            if (this.EntityName != null)
            {
                hash = hash * 59 + this.EntityName.GetHashCode();
            }

            return hash;
        }
    }
}
