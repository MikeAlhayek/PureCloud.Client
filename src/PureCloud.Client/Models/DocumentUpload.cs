using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentUpload
/// </summary>

public partial class DocumentUpload : IEquatable<DocumentUpload>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentUpload" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentUpload() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentUpload" /> class.
    /// </summary>
    /// <param name="Name">The name of the document (required).</param>
    /// <param name="Workspace">The workspace the document will be uploaded to (required).</param>
    /// <param name="Tags">Tags.</param>
    /// <param name="TagIds">TagIds.</param>
    public DocumentUpload(string Name = null, DomainEntityRef Workspace = null, List<string> Tags = null, List<string> TagIds = null)
    {
        this.Name = Name;
        this.Workspace = Workspace;
        this.Tags = Tags;
        this.TagIds = TagIds;

    }



    /// <summary>
    /// The name of the document
    /// </summary>
    /// <value>The name of the document</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The workspace the document will be uploaded to
    /// </summary>
    /// <value>The workspace the document will be uploaded to</value>
    [JsonPropertyName("workspace")]
    public DomainEntityRef Workspace { get; set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }



    /// <summary>
    /// Gets or Sets TagIds
    /// </summary>
    [JsonPropertyName("tagIds")]
    public List<string> TagIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentUpload {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Workspace: ").Append(Workspace).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  TagIds: ").Append(TagIds).Append("\n");
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
        return Equals(obj as DocumentUpload);
    }

    /// <summary>
    /// Returns true if DocumentUpload instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentUpload to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentUpload other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Workspace == other.Workspace ||
                Workspace != null &&
                Workspace.Equals(other.Workspace)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                TagIds == other.TagIds ||
                TagIds != null &&
                TagIds.SequenceEqual(other.TagIds)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Workspace != null)
            {
                hash = hash * 59 + Workspace.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (TagIds != null)
            {
                hash = hash * 59 + TagIds.GetHashCode();
            }

            return hash;
        }
    }
}
