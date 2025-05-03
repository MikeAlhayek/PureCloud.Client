using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentVersion
/// </summary>

public partial class KnowledgeDocumentVersion : IEquatable<KnowledgeDocumentVersion>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentVersion" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentVersion() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentVersion" /> class.
    /// </summary>
    /// <param name="RestoreFromVersionId">The globally unique identifier for the document version. If the value is provided, the document is restored to the given version. If not, it publishes the draft changes as a new version of the document. (required).</param>
    public KnowledgeDocumentVersion(string RestoreFromVersionId = null)
    {
        this.RestoreFromVersionId = RestoreFromVersionId;

    }



    /// <summary>
    /// Globally unique identifier for the document version.
    /// </summary>
    /// <value>Globally unique identifier for the document version.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Published date of document version. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Published date of document version. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("datePublished")]
    public DateTime? DatePublished { get; private set; }



    /// <summary>
    /// The document which is versioned.
    /// </summary>
    /// <value>The document which is versioned.</value>
    [JsonPropertyName("document")]
    public KnowledgeDocumentResponse Document { get; private set; }



    /// <summary>
    /// The globally unique identifier for the document version. If the value is provided, the document is restored to the given version. If not, it publishes the draft changes as a new version of the document.
    /// </summary>
    /// <value>The globally unique identifier for the document version. If the value is provided, the document is restored to the given version. If not, it publishes the draft changes as a new version of the document.</value>
    [JsonPropertyName("restoreFromVersionId")]
    public string RestoreFromVersionId { get; set; }



    /// <summary>
    /// Version Number of the document.
    /// </summary>
    /// <value>Version Number of the document.</value>
    [JsonPropertyName("versionNumber")]
    public int? VersionNumber { get; private set; }



    /// <summary>
    /// Expiry date of document version, applicable only to the &#39;Archived&#39; version of the document. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Expiry date of document version, applicable only to the &#39;Archived&#39; version of the document. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateExpires")]
    public DateTime? DateExpires { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentVersion {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
        sb.Append("  Document: ").Append(Document).Append("\n");
        sb.Append("  RestoreFromVersionId: ").Append(RestoreFromVersionId).Append("\n");
        sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
        sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as KnowledgeDocumentVersion);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentVersion instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentVersion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentVersion other)
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
                DatePublished == other.DatePublished ||
                DatePublished != null &&
                DatePublished.Equals(other.DatePublished)
            ) &&
            (
                Document == other.Document ||
                Document != null &&
                Document.Equals(other.Document)
            ) &&
            (
                RestoreFromVersionId == other.RestoreFromVersionId ||
                RestoreFromVersionId != null &&
                RestoreFromVersionId.Equals(other.RestoreFromVersionId)
            ) &&
            (
                VersionNumber == other.VersionNumber ||
                VersionNumber != null &&
                VersionNumber.Equals(other.VersionNumber)
            ) &&
            (
                DateExpires == other.DateExpires ||
                DateExpires != null &&
                DateExpires.Equals(other.DateExpires)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (DatePublished != null)
            {
                hash = hash * 59 + DatePublished.GetHashCode();
            }

            if (Document != null)
            {
                hash = hash * 59 + Document.GetHashCode();
            }

            if (RestoreFromVersionId != null)
            {
                hash = hash * 59 + RestoreFromVersionId.GetHashCode();
            }

            if (VersionNumber != null)
            {
                hash = hash * 59 + VersionNumber.GetHashCode();
            }

            if (DateExpires != null)
            {
                hash = hash * 59 + DateExpires.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
