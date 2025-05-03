using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentBulkVersionAddEntity
/// </summary>

public partial class KnowledgeDocumentBulkVersionAddEntity : IEquatable<KnowledgeDocumentBulkVersionAddEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentBulkVersionAddEntity" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="RestoreFromVersionId">The globally unique identifier for the document version. If the value is provided, the document is restored to the given version..</param>
    /// <param name="RestorePrevious">Indicates if the document&#39;s previous version will be restored.</param>
    public KnowledgeDocumentBulkVersionAddEntity(string Id = null, string RestoreFromVersionId = null, bool? RestorePrevious = null)
    {
        this.Id = Id;
        this.RestoreFromVersionId = RestoreFromVersionId;
        this.RestorePrevious = RestorePrevious;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The globally unique identifier for the document version. If the value is provided, the document is restored to the given version.
    /// </summary>
    /// <value>The globally unique identifier for the document version. If the value is provided, the document is restored to the given version.</value>
    [JsonPropertyName("restoreFromVersionId")]
    public string RestoreFromVersionId { get; set; }



    /// <summary>
    /// Indicates if the document&#39;s previous version will be restored
    /// </summary>
    /// <value>Indicates if the document&#39;s previous version will be restored</value>
    [JsonPropertyName("restorePrevious")]
    public bool? RestorePrevious { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentBulkVersionAddEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  RestoreFromVersionId: ").Append(RestoreFromVersionId).Append("\n");
        sb.Append("  RestorePrevious: ").Append(RestorePrevious).Append("\n");
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
        return Equals(obj as KnowledgeDocumentBulkVersionAddEntity);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentBulkVersionAddEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentBulkVersionAddEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentBulkVersionAddEntity other)
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
                RestoreFromVersionId == other.RestoreFromVersionId ||
                RestoreFromVersionId != null &&
                RestoreFromVersionId.Equals(other.RestoreFromVersionId)
            ) &&
            (
                RestorePrevious == other.RestorePrevious ||
                RestorePrevious != null &&
                RestorePrevious.Equals(other.RestorePrevious)
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

            if (RestoreFromVersionId != null)
            {
                hash = hash * 59 + RestoreFromVersionId.GetHashCode();
            }

            if (RestorePrevious != null)
            {
                hash = hash * 59 + RestorePrevious.GetHashCode();
            }

            return hash;
        }
    }
}
