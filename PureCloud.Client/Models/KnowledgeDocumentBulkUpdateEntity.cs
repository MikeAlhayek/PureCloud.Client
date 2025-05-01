using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentBulkUpdateEntity
/// </summary>
[DataContract]
public partial class KnowledgeDocumentBulkUpdateEntity : IEquatable<KnowledgeDocumentBulkUpdateEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentBulkUpdateEntity" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="CategoryId">The category associated with the document..</param>
    /// <param name="LabelIds">The ids of labels associated with the document..</param>
    public KnowledgeDocumentBulkUpdateEntity(string Id = null, string CategoryId = null, List<string> LabelIds = null)
    {
        this.Id = Id;
        this.CategoryId = CategoryId;
        this.LabelIds = LabelIds;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The category associated with the document.
    /// </summary>
    /// <value>The category associated with the document.</value>
    [DataMember(Name = "categoryId", EmitDefaultValue = false)]
    public string CategoryId { get; set; }



    /// <summary>
    /// The ids of labels associated with the document.
    /// </summary>
    /// <value>The ids of labels associated with the document.</value>
    [DataMember(Name = "labelIds", EmitDefaultValue = false)]
    public List<string> LabelIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentBulkUpdateEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
        sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
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
        return Equals(obj as KnowledgeDocumentBulkUpdateEntity);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentBulkUpdateEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentBulkUpdateEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentBulkUpdateEntity other)
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
                CategoryId == other.CategoryId ||
                CategoryId != null &&
                CategoryId.Equals(other.CategoryId)
            ) &&
            (
                LabelIds == other.LabelIds ||
                LabelIds != null &&
                LabelIds.SequenceEqual(other.LabelIds)
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

            if (CategoryId != null)
            {
                hash = hash * 59 + CategoryId.GetHashCode();
            }

            if (LabelIds != null)
            {
                hash = hash * 59 + LabelIds.GetHashCode();
            }

            return hash;
        }
    }
}
